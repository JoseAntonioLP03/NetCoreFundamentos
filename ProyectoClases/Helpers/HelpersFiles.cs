using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelpersFiles
    {
        //NECESITAMOS DOS METODOS : LEER Y ESCRIBIR
        //LOS METODOS DEBEN SER ASINCRONOS
        //EN LOS METODOS DE CLASE NO GRAFICA DEBEMOS UTILIZAR LA CLASE TASK PARA METODOS ASINCRONOS
        //1) SI ES UN VOID -> SE UTILIZA TASK
        //2) SI ES UN RETURN -> SE UTILIZA TASK<ClaseReturn>
        public async Task WriteFileAsync(string path , string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<String> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
