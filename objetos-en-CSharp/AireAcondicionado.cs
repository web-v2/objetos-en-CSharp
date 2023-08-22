namespace objetos_en_CSharp
{
    internal class AireAcondicionado
    {
        ///Atributos
        private string marca, modelo, color;
        private int voltaje, btu, temperatura;

        //Metodo Constructor con argumentos
        public AireAcondicionado(string m, string mo, string c, int v, int b, int temp)
        {
            marca = m;
            modelo = mo;
            color = c;
            voltaje = v;
            btu = b; 
            temperatura = temp;
        }
        //Metodo Constructor sin argumentos
        public AireAcondicionado()
        {
            marca = "";
            modelo = "";
            color = "";
            voltaje = 0;
            btu = 0;
            temperatura = 0;
        }
        //Metodos Getters y Setters
        public String getMarca()
        {
            return marca;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public String getModelo()
        {
            return modelo;
        }

        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public int getVoltaje()
        {
            return voltaje;
        }

        public void setVoltaje(int voltaje)
        {
            this.voltaje = voltaje;
        }

        public int getBtu()
        {
            return btu;
        }

        public void setBtu(int btu)
        {
            this.btu = btu;
        }

        public int getTemperatura()
        {
            return temperatura;
        }

        public void setTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }




        public void subirTemperatura()
        {
            if(this.temperatura < 30)
            {
                temperatura++;
            }
        }

        public void bajarTemperatura()
        {
            if(temperatura > 16)
            {
                temperatura--;
            }
        }

        //SobreCarga de Metodos
        public void subirTemperatura(int temp)
        {
            if (this.temperatura < 30 && temp < 30)
            {
                this.temperatura = temp;
            }
        }

        public void bajarTemperatura(int temp)
        {
            if (temperatura > 16 && temp > 16)
            {
                this.temperatura=temp;
            }
        }
    }
}