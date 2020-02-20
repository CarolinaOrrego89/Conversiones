using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversionesdeunidades
{
    public partial class Form1 : Form
    {
        conversor objConversor = new conversor();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            lblDinero.Text = Math.Round(

               objConversor.monedas(
                   double.Parse(txtDineros.Text), cboDinero.SelectedIndex, cboDineros.SelectedIndex, 0
               )

               , 2).ToString();
        }

        private void btnlongtud_Click(object sender, EventArgs e)
        {
            double medida;


                string from, to;

                from = cbolongtud.SelectedItem.ToString();
                to = cbolongtuds.SelectedItem.ToString();


                double Cantidad = double.Parse(txtlongtud.Text),
                Date = 0;

                switch (cbolongtud.SelectedIndex)
                {

                    case 0:
                        if (from == "Metro" && to == "Centimetro")
                        {
                            Date = Cantidad * 100;

                        }

                        if (from == "Metro" && to == "Kilometro")
                        {
                            Date = Cantidad / 1000;

                        }
                        if (from == "Metro" && to == "Yardas")
                        {
                            Date = Cantidad * 1.094;
                        }

                        if (from == "Metro" && to == "Pies")
                        {
                            Date = Cantidad * 3.281;
                        }
                        if (from == "Metro" && to == "Millas")
                        {
                            Date = Cantidad / 1609;

                        }
                        break;
                    case 1:
                        if (from == "Centimetro" && to == "Metro")
                        {
                            Date = Cantidad / 100;
                        }
                        if (from == "Centimetro" && to == "Yardas")
                        {
                            Date = Cantidad / 91.44;
                        }
                        if (from == "Centimetro" && to == "Millas")
                        {
                            Date = Cantidad / 160934;
                        }
                        if (from == "Centimetro" && to == "Kilometros")
                        {
                            Date = Cantidad / 100000;
                        }
                        if (from == "Centimetro" && to == "Pies")
                        {
                            Date = Cantidad / 30.48;

                        }
                        break;
                    case 2:
                        if (from == "Yardas" && to == "Metro")
                        {
                            Date = Cantidad / 1.094;

                        }
                        if (from == "Yardas" && to == "Centimetro")
                        {
                            Date = Cantidad * 91.44;
                        }
                        if (from == "Yardas" && to == "Pies")
                        {
                            Date = Cantidad * 3;
                        }
                        if (from == "Yardas" && to == "Kilometros")
                        {
                            Date = Cantidad / 1094;
                        }
                        if (from == "Yardas" && to == "Millas")
                        {
                            Date = Cantidad / 1760;
                        }
                        break;
                    case 3:
                        if (from == "Pies" && to == "Metros")
                        {
                            Date = Cantidad / 3.281;
                        }
                        if (from == "Pies" && to == "Centimetros")
                        {
                            Date = Cantidad * 30.48;
                        }
                        if (from == "Pies" && to == "Yardas")
                        {
                            Date = Cantidad / 3;
                        }
                        if (from == "Pies" && to == "Kilometros")
                        {
                            Date = Cantidad / 3281;

                        }
                        if (from == "Pies" && to == "Millas")
                        {
                            Date = Cantidad / 5280;

                        }
                        break;
                    case 4:
                        if (from == "Kilometros" && to == "Metros")
                        {
                            Date = Cantidad * 1000;
                        }
                        if (from == "Kilometros" && to == "Centimetros")
                        {
                            Date = Cantidad * 100000;
                        }
                        if (from == "Kilometros" && to == "Yardas")
                        {
                            Date = Cantidad * 1094;
                        }
                        if (from == "Kilometros" && to == "Pies")
                        {
                            Date = Cantidad * 3281;
                        }
                        if (from == "Kilometros" && to == "Millas")
                        {
                            Date = Cantidad / 1.609;
                        }
                        break;
                    case 5:
                        if (from == "Millas" && to == "Metros")
                        {
                            Date = Cantidad * 1609;
                        }
                        if (from == "Millas" && to == "Centimetros")
                        {
                            Date = Cantidad * 160934;
                        }
                        if (from == "Millas" && to == "Yardas")
                        {
                            Date = Cantidad * 1760;
                        }
                        if (from == "Millas" && to == "Pies")
                        {
                            Date = Cantidad * 5280;
                        }
                        if (from == "Millas" && to == "Kilometros")
                        {
                            Date = Cantidad * 1.609;
                        }
                        break;
                }


                switch (cbolongtuds.SelectedIndex)
                {

                    case 0:
                        if (from == "Metro" && to == "Centimetro")
                        {
                            Date = Cantidad * 100;

                        }

                        if (from == "Metro" && to == "Kilometro")
                        {
                            Date = Cantidad / 1000;

                        }
                        if (from == "Metro" && to == "Yardas")
                        {
                            Date = Cantidad * 1.094;
                        }

                        if (from == "Metro" && to == "Pies")
                        {
                            Date = Cantidad * 3.281;
                        }
                        if (from == "Metro" && to == "Millas")
                        {
                            Date = Cantidad / 1609;

                        }
                        break;
                    case 1:
                        if (from == "Centimetro" && to == "Metro")
                        {
                            Date = Cantidad / 100;
                        }
                        if (from == "Centimetro" && to == "Yardas")
                        {
                            Date = Cantidad / 91.44;
                        }
                        if (from == "Centimetro" && to == "Millas")
                        {
                            Date = Cantidad / 160934;
                        }
                        if (from == "Centimetro" && to == "Kilometros")
                        {
                            Date = Cantidad / 100000;
                        }
                        if (from == "Centimetro" && to == "Pies")
                        {
                            Date = Cantidad / 30.48;

                        }
                        break;
                    case 2:
                        if (from == "Yardas" && to == "Metro")
                        {
                            Date = Cantidad / 1.094;

                        }
                        if (from == "Yardas" && to == "Centimetro")
                        {
                            Date = Cantidad * 91.44;
                        }
                        if (from == "Yardas" && to == "Pies")
                        {
                            Date = Cantidad * 3;
                        }
                        if (from == "Yardas" && to == "Kilometros")
                        {
                            Date = Cantidad / 1094;
                        }
                        if (from == "Yardas" && to == "Millas")
                        {
                            Date = Cantidad / 1760;
                        }
                        break;
                    case 3:
                        if (from == "Pies" && to == "Metros")
                        {
                            Date = Cantidad / 3.281;
                        }
                        if (from == "Pies" && to == "Centimetros")
                        {
                            Date = Cantidad * 30.48;
                        }
                        if (from == "Pies" && to == "Yardas")
                        {
                            Date = Cantidad / 3;
                        }
                        if (from == "Pies" && to == "Kilometros")
                        {
                            Date = Cantidad / 3281;

                        }
                        if (from == "Pies" && to == "Millas")
                        {
                            Date = Cantidad / 5280;

                        }
                        break;
                    case 4:
                        if (from == "Kilometros" && to == "Metros")
                        {
                            Date = Cantidad * 1000;
                        }
                        if (from == "Kilometros" && to == "Centimetros")
                        {
                            Date = Cantidad * 100000;
                        }
                        if (from == "Kilometros" && to == "Yardas")
                        {
                            Date = Cantidad * 1094;
                        }
                        if (from == "Kilometros" && to == "Pies")
                        {
                            Date = Cantidad * 3281;
                        }
                        if (from == "Kilometros" && to == "Millas")
                        {
                            Date = Cantidad / 1.609;
                        }
                        break;
                    case 5:
                        if (from == "Millas" && to == "Metros")
                        {
                            Date = Cantidad * 1609;
                        }
                        if (from == "Millas" && to == "Centimetros")
                        {
                            Date = Cantidad * 160934;
                        }
                        if (from == "Millas" && to == "Yardas")
                        {
                            Date = Cantidad * 1760;
                        }
                        if (from == "Millas" && to == "Pies")
                        {
                            Date = Cantidad * 5280;
                        }
                        if (from == "Millas" && to == "Kilometros")
                        {
                            Date = Cantidad * 1.609;
                        }
                        break;
                }
                medida = Math.Round(Date, 2);
                lbllongtud.Text = "Respuesta: " + medida;
            }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double PS;
            string from, to;

            from = cboPeso.SelectedItem.ToString();
            to = cboPesos.SelectedItem.ToString();

            double Cantidad = double.Parse(txtPeso.Text),
            dato = 0;
            switch (cboPeso.SelectedIndex)
            {
                case 0://GR

                    if (from == "Gramos" && to == "Miligramo")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Gramos" && to == "Microgramo")
                    {
                        dato = Cantidad * 1e+6;

                    }
                    if (from == "Gramos" && to == "Kilogramos")
                    {
                        dato = Cantidad / 1000;

                    }
                    if (from == "Gramos" && to == "Libras")
                    {
                        dato = Cantidad / 454;

                    }
                    if (from == "Gramos" && to == "Onzas")
                    {
                        dato = Cantidad / 28.35;

                    }
                    break;
                case 1://MILI
                    if (from == "Miligramo" && to == "Gramo")
                    {
                        dato = Cantidad / 1000;

                    }
                    if (from == "Miligramo" && to == "Microgramo")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Miligramo" && to == "Kilogramos")
                    {
                        dato = Cantidad / 1e+6;

                    }
                    if (from == "Miligramo" && to == "Libras")
                    {
                        dato = Cantidad / 453592;

                    }
                    if (from == "Miligramo" && to == "Onzas")
                    {
                        dato = Cantidad / 28350;

                    }
                    break;
                case 2://MICRO
                    if (from == "Microgramos" && to == "Gramos")
                    {
                        dato = Cantidad / 1e+6;

                    }
                    if (from == "Microgramos" && to == "Miligramo")
                    {
                        dato = Cantidad / 1000;

                    }
                    if (from == "Microgramos" && to == "Kilogramos")
                    {
                        dato = Cantidad / 1e+9;

                    }
                    if (from == "Microgramos" && to == "Libras")
                    {
                        dato = Cantidad / 4.536e+8;

                    }
                    if (from == "Microgramos" && to == "Onzas")
                    {
                        dato = Cantidad / 2.835e+7;

                    }
                    break;
                case 3://KG
                    if (from == "Kilogramos" && to == "Gramos")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Kilogramos" && to == "Miligramos")
                    {
                        dato = Cantidad * 1e+6;

                    }
                    if (from == "Kilogramos" && to == "Microgramos")
                    {
                        dato = Cantidad * 1e+9;

                    }
                    if (from == "Kilogramos" && to == "Libras")
                    {
                        dato = Cantidad * 2.205;

                    }
                    if (from == "Kilogramos" && to == "Onzas")
                    {
                        dato = Cantidad * 35.274;

                    }
                    break;
                case 4://LB
                    if (from == "Libras" && to == "Gramos")
                    {
                        dato = Cantidad * 454;

                    }
                    if (from == "Libras" && to == "Miligramos")
                    {
                        dato = Cantidad * 453592;

                    }
                    if (from == "Libras" && to == "Microgramos")
                    {
                        dato = Cantidad * 4.536e+8;

                    }
                    if (from == "Libras" && to == "Kilogramos")
                    {
                        dato = Cantidad / 2.205;

                    }
                    if (from == "Libras" && to == "Onzas")
                    {
                        dato = Cantidad * 16;

                    }
                    break;
                case 5://ONZ
                    if (from == "Onzas" && to == "Gramos")
                    {
                        dato = Cantidad * 28.35;

                    }
                    if (from == "Onzas" && to == "Miligramos")
                    {
                        dato = Cantidad * 28350;

                    }
                    if (from == "Onzas" && to == "Microgramos")
                    {
                        dato = Cantidad * 2.835e+7;

                    }
                    if (from == "Onzas" && to == "Kilogramos")
                    {
                        dato = Cantidad / 35.274;

                    }
                    if (from == "Onzas" && to == "Libras")
                    {
                        dato = Cantidad / 16;

                    }
                    break;

            }

            switch (cboPesos.SelectedIndex)
            {
                case 0://GR

                    if (from == "Gramos" && to == "Miligramo")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Gramos" && to == "Microgramo")
                    {
                        dato = Cantidad * 1e+6;

                    }
                    if (from == "Gramos" && to == "Kilogramos")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Gramos" && to == "Libras")
                    {
                        dato = Cantidad / 454;

                    }
                    if (from == "Gramos" && to == "Onzas")
                    {
                        dato = Cantidad / 28.35;

                    }
                    break;
                case 1://MILI
                    if (from == "Miligramo" && to == "Gramo")
                    {
                        dato = Cantidad / 1000;

                    }
                    if (from == "Miligramo" && to == "Microgramo")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Miligramo" && to == "Kilogramos")
                    {
                        dato = Cantidad / 1e+6;

                    }
                    if (from == "Miligramo" && to == "Libras")
                    {
                        dato = Cantidad / 453592;

                    }
                    if (from == "Miligramo" && to == "Onzas")
                    {
                        dato = Cantidad / 28350;

                    }
                    break;
                case 2://MICRO
                    if (from == "Microgramos" && to == "Gramos")
                    {
                        dato = Cantidad / 1e+6;

                    }
                    if (from == "Microgramos" && to == "Miligramo")
                    {
                        dato = Cantidad / 1000;

                    }
                    if (from == "Microgramos" && to == "Kilogramos")
                    {
                        dato = Cantidad / 1e+9;

                    }
                    if (from == "Microgramos" && to == "Libras")
                    {
                        dato = Cantidad / 4.536e+8;

                    }
                    if (from == "Microgramos" && to == "Onzas")
                    {
                        dato = Cantidad / 2.835e+7;

                    }
                    break;
                case 3://KG
                    if (from == "Kilogramos" && to == "Gramos")
                    {
                        dato = Cantidad * 1000;

                    }
                    if (from == "Kilogramos" && to == "Miligramos")
                    {
                        dato = Cantidad * 1e+6;

                    }
                    if (from == "Kilogramos" && to == "Microgramos")
                    {
                        dato = Cantidad * 1e+9;

                    }
                    if (from == "Kilogramos" && to == "Libras")
                    {
                        dato = Cantidad * 2.205;

                    }
                    if (from == "Kilogramos" && to == "Onzas")
                    {
                        dato = Cantidad * 35.274;

                    }
                    break;
                case 4://LB
                    if (from == "Libras" && to == "Gramos")
                    {
                        dato = Cantidad * 454;

                    }
                    if (from == "Libras" && to == "Miligramos")
                    {
                        dato = Cantidad * 453592;

                    }
                    if (from == "Libras" && to == "Microgramos")
                    {
                        dato = Cantidad * 4.536e+8;

                    }
                    if (from == "Libras" && to == "Kilogramos")
                    {
                        dato = Cantidad / 2.205;

                    }
                    if (from == "Libras" && to == "Onzas")
                    {
                        dato = Cantidad * 16;

                    }
                    break;
                case 5://ONZ
                    if (from == "Onzas" && to == "Gramos")
                    {
                        dato = Cantidad * 28.35;

                    }
                    if (from == "Onzas" && to == "Miligramos")
                    {
                        dato = Cantidad * 28350;

                    }
                    if (from == "Onzas" && to == "Microgramos")
                    {
                        dato = Cantidad * 2.835e+7;

                    }
                    if (from == "Onzas" && to == "Kilogramos")
                    {
                        dato = Cantidad / 35.274;

                    }
                    if (from == "Onzas" && to == "Libras")
                    {
                        dato = Cantidad / 16;

                    }
                    break;
            }
            PS = Math.Round(dato, 2);

            lblPeso.Text = "Respuesta: " + PS;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            double Tmprtr = double.Parse(txtTemp.Text), DateTemper = 0;
            string from, to;

            from = cboTemp.SelectedItem.ToString();
            to = cboTemps.SelectedItem.ToString();
            switch (cboTemp.SelectedIndex)
            {

                case 0://Celcius
                    if (from == "Celcius" && to == "Farenheit")
                    {
                        DateTemper = (Tmprtr * 9 / 5) + 32;

                    }
                    if (from == "Celcius" && to == "Kelvin")
                    {
                        DateTemper = Tmprtr + 273.15;

                    }

                    break;
                case 1://Farenheit
                    if (from == "Farenheit" && to == "Celcius")
                    {
                        DateTemper = (Tmprtr - 32) * 5 / 9;

                    }
                    if (from == "Farenheit" && to == "Kelvin")
                    {
                        DateTemper = (Tmprtr - 32) * 5 / 9 + 273.15;

                    }


                    break;
                case 2://Kelvin
                    if (from == "Kelvin" && to == "Celcius")
                    {
                        DateTemper = Tmprtr - 273.15;

                    }
                    if (from == "Kelvin" && to == "Farenheit")
                    {
                        DateTemper = (Tmprtr - 273.15) * 9 / 5 + 32;

                    }


                    break;


            }

            switch (cboTemps.SelectedIndex)
            {
                case 0://Celcius
                    if (from == "Celcius" && to == "Farenheit")
                    {
                        DateTemper = (Tmprtr * 9 / 5) + 32;

                    }
                    if (from == "Celcius" && to == "Kelvin")
                    {
                        DateTemper = Tmprtr + 273.15;

                    }

                    break;
                case 1://Farenheit
                    if (from == "Farenheit" && to == "Celcius")
                    {
                        DateTemper = (Tmprtr - 32) * 5 / 9;

                    }
                    if (from == "Farenheit" && to == "Kelvin")
                    {
                        DateTemper = (Tmprtr - 32) * 5 / 9 + 273.15;

                    }


                    break;
                case 2://Kelvin
                    if (from == "Kelvin" && to == "Celcius")
                    {
                        DateTemper = Tmprtr - 273.15;

                    }
                    if (from == "Kelvin" && to == "Farenheit")
                    {
                        DateTemper = (Tmprtr - 273.15) * 9 / 5 + 32;

                    }


                    break;
            }
            lblTemps.Text = "Respuesta: " + DateTemper + "\n";

        }

        private void btnNamiento_Click(object sender, EventArgs e)
        {
            double Almacena;
            double Alma = double.Parse(txtNamiento.Text), StorageData = 0;
            string from, to;

            from = cboNamiento.SelectedItem.ToString();
            to = cboNamientos.SelectedItem.ToString();
            switch (cboNamiento.SelectedIndex)
            {

                case 0:
                    if (from == "Bit" && to == "Byte")
                    {
                        StorageData = Alma / 8;

                    }
                    if (from == "Bit" && to == "KILOBYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "Bit" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 8e+6;

                    }
                    if (from == "Bit" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 8e+9;

                    }
                    if (from == "Bit" && to == "TERABYTE")
                    {
                        StorageData = Alma / 8e+12;

                    }
                    if (from == "Bit" && to == "PETABYTE")
                    {
                        StorageData = Alma / 8e+15;

                    }



                    break;
                case 1://BYTE
                    if (from == "Byte" && to == "Bit")
                    {
                        StorageData = Alma * 8;

                    }
                    if (from == "Byte" && to == "KILOBYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "Byte" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    if (from == "Byte" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 1e+9;

                    }
                    if (from == "Byte" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1e+12;

                    }
                    if (from == "Byte" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+15;

                    }
                    break;
                case 2://KILOBYTE
                    if (from == "KILOBYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8000;

                    }
                    if (from == "KILOBYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1000;

                    }
                    if (from == "KILOBYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "KILOBYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    if (from == "KILOBYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1e+9;

                    }
                    if (from == "KILOBYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+12;

                    }
                    break;
                case 3://MEGABYTE
                    if (from == "MEGABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "MEGABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 125000;

                    }
                    if (from == "MEGABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 125;

                    }
                    if (from == "MEGABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "MEGABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 8e+6;

                    }
                    if (from == "MEGABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 8e+9;

                    }

                    break;
                case 4://GIGABYTE
                    if (from == "GIGABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8e+9;

                    }
                    if (from == "GIGABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "GIGABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "GIGABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "GIGABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "GIGABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    break;
                case 5://TERABYTE
                    if (from == "TERABYTE" && to == "BIT")
                    {
                        StorageData = Alma * 8e+12;

                    }
                    if (from == "TERABYTE" && to == "BYTE")
                    {
                        StorageData = Alma * 1e+12;

                    }
                    if (from == "TERABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "TERABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "TERABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma * 1000;

                    }
                    if (from == "TERABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    break;
                case 6://PETABYTE
                    if (from == "PETABYTE" && to == "BIT")
                    {
                        StorageData = Alma * 8e+15;

                    }
                    if (from == "PETABYTE" && to == "BYTE")
                    {
                        StorageData = Alma * 1e+15;

                    }
                    if (from == "PETABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+12;

                    }
                    if (from == "PETABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "PETABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "PETABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma * 1000;

                    }
                    break;




            }

            switch (cboNamientos.SelectedIndex)
            {
                case 0://BIT
                    if (from == "Bit" && to == "Byte")
                    {
                        StorageData = Alma / 8;

                    }
                    if (from == "Bit" && to == "KILOBYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "Bit" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 8e+6;

                    }
                    if (from == "Bit" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 8e+9;

                    }
                    if (from == "Bit" && to == "TERABYTE")
                    {
                        StorageData = Alma / 8e+12;

                    }
                    if (from == "Bit" && to == "PETABYTE")
                    {
                        StorageData = Alma / 8e+15;

                    }



                    break;
                case 1://BYTE
                    if (from == "Byte" && to == "Bit")
                    {
                        StorageData = Alma * 8;

                    }
                    if (from == "Byte" && to == "KILOBYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "Byte" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    if (from == "Byte" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 1e+9;

                    }
                    if (from == "Byte" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1e+12;

                    }
                    if (from == "Byte" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+15;

                    }
                    break;
                case 2://KILOBYTE
                    if (from == "KILOBYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8000;

                    }
                    if (from == "KILOBYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1000;

                    }
                    if (from == "KILOBYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "KILOBYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    if (from == "KILOBYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1e+9;

                    }
                    if (from == "KILOBYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+12;

                    }
                    break;
                case 3://MEGABYTE
                    if (from == "MEGABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "MEGABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 125000;

                    }
                    if (from == "MEGABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 125;

                    }
                    if (from == "MEGABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "MEGABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 8e+6;

                    }
                    if (from == "MEGABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 8e+9;

                    }

                    break;
                case 4://GIGABYTE
                    if (from == "GIGABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8e+9;

                    }
                    if (from == "GIGABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "GIGABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "GIGABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma / 8000;

                    }
                    if (from == "GIGABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    if (from == "GIGABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1e+6;

                    }
                    break;
                case 5://TERABYTE
                    if (from == "TERABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8e+12;

                    }
                    if (from == "TERABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1e+12;

                    }
                    if (from == "TERABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "TERABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "TERABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma * 1000;

                    }
                    if (from == "TERABYTE" && to == "PETABYTE")
                    {
                        StorageData = Alma / 1000;

                    }
                    break;
                case 6://PETABYTE
                    if (from == "PETABYTE" && to == "Bit")
                    {
                        StorageData = Alma * 8e+15;

                    }
                    if (from == "PETABYTE" && to == "Byte")
                    {
                        StorageData = Alma * 1e+15;

                    }
                    if (from == "PETABYTE" && to == "KILOBYTE")
                    {
                        StorageData = Alma * 1e+12;

                    }
                    if (from == "PETABYTE" && to == "MEGABYTE")
                    {
                        StorageData = Alma * 1e+9;

                    }
                    if (from == "PETABYTE" && to == "GIGABYTE")
                    {
                        StorageData = Alma * 1e+6;

                    }
                    if (from == "PETABYTE" && to == "TERABYTE")
                    {
                        StorageData = Alma * 1000;

                    }
                    break;
            }
            Almacena = Math.Round(StorageData, 2);
            lblNamientos.Text = "Respuesta: " + StorageData;
        }
    }
    }
                      

