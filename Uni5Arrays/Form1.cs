using Microsoft.VisualBasic.Logging;

namespace Uni5Arrays
{
    public partial class Form1 : Form
    {
        string[] myColors;
        int index;
        Employee[] myEmployee;
        Employee[,] myEmployeeMatrix = new Employee[3, 3];
        Employee[,,] myEmployee3D;
        public Form1()
        {
            InitializeComponent();
            index = 0;
            myColors = new string[5];

            myEmployee = new Employee[3];
            myEmployeeMatrix = new Employee[3, 3];
            myEmployee3D = new Employee[3, 3, 3];

            for (int row = 0; row < myEmployeeMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < myEmployeeMatrix.GetLength(1); column++)
                {
                    myEmployeeMatrix[row, column] = new Employee();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        myEmployee3D[i, j, k] = new Employee();
                    }
                }
            }
        }

        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            if (index == myColors.Length)
            {
                string colorText = "";
                for (int i = 0; i < myColors.Length; i++)
                {
                    colorText += myColors[i] + " ";
                }
                lblColor.Text = colorText;
                return;
            }
            try
            {
                myColors[index++] = txtColor.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (index == myEmployee.Length)
            {
                string data = "";
                for (int i = 0; i < myEmployee.Length; i++)
                {
                    data += myEmployee[i].ToString() + "\n";
                    lblData.Text = data;
                }
                PrintEmployeeData3D(); // Llamada a la función para imprimir los datos tridimensionales.
                return;
            }
            try
            {
                myEmployee[index] = new Employee(txtName.Text, int.Parse(txtSalary.Text), txtSex.Text);
                index++;

                txtName.Text = "";
                txtSalary.Text = "";
                txtSex.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");
            }
        }

        private void PrintEmployeeData3D()
        {
            Console.WriteLine("Datos de empleados (Arreglo Tridimensional):");
            for (int i = 0; i < myEmployee3D.GetLength(0); i++)
            {
                for (int j = 0; j < myEmployee3D.GetLength(1); j++)
                {
                    for (int k = 0; k < myEmployee3D.GetLength(2); k++)
                    {
                        Console.WriteLine("Empleado en posición ({0}, {1}, {2}): {3}", i, j, k, myEmployee3D[i, j, k].ToString());
                    }
                }
            }
        }
    }
}



