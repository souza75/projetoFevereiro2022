using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projetoFevereiro2022
{
    public class Serie
    {
      
        private String nomeSerie;
        private String genero;
     

        public Serie(String nomeSerie, String genero)
        {
           
            this.nomeSerie = nomeSerie;
            this.genero = genero;
         
            
        }



        public String getNomeSerie()
        {
            return nomeSerie;
        }

        public void setNomeSerie()
        {
            this.nomeSerie = nomeSerie;
        }

        public String getGenero()
        {
            return genero;
        }

        public void setGenero()
            {
            this.genero= genero;
        }

      

      override
            public String toString()
        {
            return "Serie{" +  ", nomeSerie=" + nomeSerie + ", genero=" + genero +  '}';
        }
    }   
}
