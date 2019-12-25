using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulstuEgov
{
    public partial class FormBusTerminal : Form
    {
        MultiLevelParking levelTerminal;

        private const int countLevel = 5;

        private Logger logger;
        public FormBusTerminal()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            levelTerminal = new MultiLevelParking(countLevel, pictureBoxTerminal.Width, pictureBoxTerminal.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1) {
                Bitmap bitmap = new Bitmap(pictureBoxTerminal.Width, pictureBoxTerminal.Height);
                Graphics g = Graphics.FromImage(bitmap);
                levelTerminal[listBoxLevels.SelectedIndex].Draw(g);
                pictureBoxTerminal.Image = bitmap;
            }
        }

        private void ParkingBaseBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var bus = new BaseBus(20, dialog.Color, 10, Color.Black);
                    int place = levelTerminal[listBoxLevels.SelectedIndex] + bus;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void ParkingBusWithAccord_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var bus = new BusWithAccord(20, dialog.Color, 10, Color.Black, dialogDop.Color, 20, 1, 50);
                        int place = levelTerminal[listBoxLevels.SelectedIndex] + bus;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void GetCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxIndex.Text != "")
                {
                    try
                    {
                        var car = levelTerminal[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxIndex.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                        pictureBoxTake.Height);
                        Graphics g = Graphics.FromImage(bmp);
                        car.SetPosition(pictureBoxTake.Width / 2 - 30, pictureBoxTake.Height / 2, pictureBoxTake.Width,
                        pictureBoxTake.Height);
                        car.Draw(g);
                        pictureBoxTake.Image = bmp;
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        logger.Error(ex);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex);
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ListBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void SelectAuto_Click(object sender, EventArgs e)
        {
            FormBusConfig form = new FormBusConfig();
            form.AddEvent(AddCar);
            form.Show();
        }

        private void AddCar(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = levelTerminal[listBoxLevels.SelectedIndex] + car;
                    logger.Info("Добавлен автомобиль " + car.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error(ex);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    levelTerminal.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    levelTerminal.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error(ex);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}