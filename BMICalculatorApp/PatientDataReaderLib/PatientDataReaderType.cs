using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDataReaderLib
{
    public class PatientDataReaderType
    {
     
        public PatientDataLib.PatientDataType GetPatient(string path)
        {

            for (int i = 0; i <line.Count; i++)
            {
                Console.Write(line[i] );
            }
            Console.WriteLine();
        }


        
        private List<string> GetLine(string path)
        {
            System.IO.StreamReader _reader = new System.IO.StreamReader(path);
            List<string> lines = new List<string>();
            while (!_reader.EndOfStream)
            {
                string pathLines = _reader.ReadLine();
                lines.Add(pathLines);
            }
            _reader.Close();
            return lines;
        }

        private PatientDataLib.PatientDataType GetLineItem(string path)
        {
            string[] line = line.Split(',');
            PatientDataLib.PatientDataType _data= new PatientDataLib.PatientDataType();
            _data.Name = line[0];
            _data.Height = line[1];
            _data.weight = line[2];
        }



    }
    }

