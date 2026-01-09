using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelpersFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelpersFiles();
            this.path = "mascotas.txt";
        }

        //CONVERTIR EL STRING DEL READ A LIST
        private void ConvertirMascotasList(string data)
        {
            //EJEMPLO:  GARFIELD,FATO@PLUTO,PERRO
            this.Mascotas.Clear();
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ','
                string[] propiedades = stringMascota.Split(',');
                //CONVERTIMOS EN TRISTE STRING EN OBJETOS
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        
        //EL PROGRAMADOR ESCRIBA READ , LEEMOS UN STRING Y RELLENAMOS LA COLECCION
        public async Task ReadMoscotaAsync()
        {
            //LEEMOS EL FICHERO DE MASCOTAS
            string data = await this.helper.ReadFileAsync(this.path);
            //CONVERTIMOS EL STRING EN LIST
            this.ConvertirMascotasList(data);
        }

        //CONVERTIMOS LA COLECCION A STRING 
        private string ConvertirColeccionString()
        {
            //EJEMPLO:  GARFIELD,FATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE ','
                //PLUTO,PERRO
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        //EL PROGRAMADOR ESCRIBA WRITE Y GUARDAMOS LAS MASCOTAS
        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirColeccionString();
            //ESCRIBIMOS LOS DATOS EN FILE 
            await this.helper.WriteFileAsync(this.path, data);
        }
    }
}
