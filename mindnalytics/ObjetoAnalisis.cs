using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
   

    class ObjetoAnalisis
    {
        private string NombreOA;            //Nombre del objeto
        private string NombreExperimento;   //Nombre del experimento 
        private string Grupo;               //Grupo de assets
        private string Path;                //Ruta del asset


        private int QRP;                    //Valores positivos de la prueba Exitement
        private int QRN;                    //Valores neutrales de la prueba Exitement
        private int QRM;                    //Valores negativos de la prueba Exitement
        private int QRPEn;                  //Valores positivos de la prueba Engagement
        private int QRNEn;                  //Valores neutrales de la prueba Engagement
        private int QRMEn;                  //Valores negativos de la prueba Engagement
        private int QRPMe;                  //Valores positivos de la prueba Meditation
        private int QRNMe;                  //Valores neutrales de la prueba Meditation
        private int QRMMe;                  //Valores negativos de la prueba Meditation
        private int QRPFr;                  //Valores positivos de la prueba Frustration
        private int QRNFr;                  //Valores neutrales de la prueba Frustration
        private int QRMFr;                  //Valores negativos de la prueba Frustration

        //Valores en bruto de la prueba
        private List<Double> ScoreEngage ;
        private List<Double> ScoreExcitement;
        private List<Double> ScoreMeditation;
        private List<Double> ScoreFrustration;

        public ObjetoAnalisis()
        {
            this.NombreOA = "";
            this.NombreExperimento = "";
            this.Grupo = "";
            this.Path = "";
            this.QRP = 0;
            this.QRN = 0;
            this.QRM = 0;

            this.QRPEn = 0;
            this.QRNEn = 0;
            this.QRMEn = 0;

            this.QRPMe = 0;
            this.QRNMe = 0;
            this.QRMMe = 0;

            this.QRPFr = 0;
            this.QRNFr = 0;
            this.QRMFr = 0;

            this.ScoreEngage = new List<double>();
            this.ScoreExcitement = new List<double>();
            this.ScoreMeditation = new List<double>();
            this.ScoreFrustration = new List<double>();
        }

        public ObjetoAnalisis(string NombreOA, string NombreExperimento, string Grupo, string Path, int QRP, int QRN, int QRM, int QRPEn,int QRNEn , int QRMEn  ,int QRPMe ,int QRNMe , int QRMMe , int QRPFr, int QRNFr, int QRMFr , List<Double> ScoreEngage, List<Double> ScoreExcitement, List<Double> ScoreMeditation, List<Double> ScoreFrustration)
        {
            this.NombreOA = NombreOA;
            this.NombreExperimento = NombreExperimento;
            this.Grupo = Grupo;
            this.Path = Path;
            this.QRP = QRP;
            this.QRN = QRN;
            this.QRM = QRM;

            this.QRPEn = QRPEn;
            this.QRNEn = QRNEn;
            this.QRMEn = QRMEn;
            
            this.QRPMe = QRPMe;
            this.QRNMe = QRNMe;
            this.QRMMe = QRMMe;
            
            this.QRPFr = QRPFr;
            this.QRNFr = QRNFr;
            this.QRMFr = QRMFr;

            this.ScoreEngage = ScoreEngage;
            this.ScoreExcitement = ScoreExcitement;
            this.ScoreMeditation = ScoreMeditation;
            this.ScoreFrustration = ScoreFrustration;
            
        }

        public void Save(String FilePath, String FileName)
        {
            ExcelManipulator.saveOA(this, FilePath, FileName);
        }


        public string grupo
        {
            get { return Grupo; }
            set { Grupo = value; }
        }

        public string nombreOA
        {
            get { return NombreOA; }
            set { NombreOA = value; }
        }

        public string path
        {
            get { return Path; }
            set { Path = value; }
        }

        public int qrp
        {
            get { return QRP; }
            set { QRP = value; }
        }

        public int qrn
        {
            get { return QRN; }
            set { QRN = value; }
        }

        public int qrm
        {
            get { return QRM; }
            set { QRM = value; }
        }



        public int qrpEn
        {
            get { return QRPEn; }
            set { QRPEn = value; }
        }

        public int qrnEn
        {
            get { return QRNEn; }
            set { QRNEn = value; }
        }

        public int qrmEn
        {
            get { return QRMEn; }
            set { QRMEn = value; }
        }


        public int qrpMe
        {
            get { return QRPMe; }
            set { QRPMe = value; }
        }

        public int qrnMe
        {
            get { return QRNMe; }
            set { QRNMe = value; }
        }

        public int qrmMe
        {
            get { return QRMMe; }
            set { QRMMe = value; }
        }

        public int qrpFr
        {
            get { return QRPFr; }
            set { QRPFr = value; }
        }

        public int qrnFr
        {
            get { return QRNFr; }
            set { QRNFr = value; }
        }

        public int qrmFr
        {
            get { return QRMFr; }
            set { QRMFr = value; }
        }



        public string nombreExperimento
        {
            get { return NombreExperimento; }
            set { NombreExperimento = value; }
        }

        public List<Double> scoreEngage
        {
            get { return ScoreEngage; }
            set { ScoreEngage = value; }
        }

        public List<Double> scoreExcitement
        {
            get { return ScoreExcitement; }
            set { ScoreExcitement = value; }
        }

        public List<Double> scoreMeditation
        {
            get { return ScoreMeditation; }
            set { ScoreMeditation = value; }
        }

        public List<Double> scoreFrustration
        {
            get { return ScoreFrustration; }
            set { ScoreFrustration = value; }
        }
    }
}
