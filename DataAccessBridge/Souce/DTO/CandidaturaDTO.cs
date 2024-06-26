using DataAccessBridge.Utils;

namespace DataAccessBridge.DTO
{
    /// <summary>
    /// Objeto representativo de una candidatura política
    /// </summary>
    public class CandidaturaDTO : ICloneable
    {

        #region Properties

        /// <summary>
        /// Identificador de la candidatura
        /// </summary>
        public long Id { get; set; } = Constants.LONG_UNDEFINED;

        /// <summary>
        /// Nombre de la candidatura
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Número total de votos
        /// </summary>
        public long Votes { get; set; } = Constants.LONG_UNDEFINED;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public CandidaturaDTO() { }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Clona el objeto actual
        /// </summary>
        /// <returns>Una clonación del objeto actual</returns>
        public object Clone()
        {
            CandidaturaDTO result = new CandidaturaDTO()
            {
                Id = this.Id,
                Name = this.Name,
                Votes = this.Votes
            };

            return result;
        }

        /// <summary>
        /// Compara el objeto actual con el objeto recibido y devuelve un booleano que indica si son iguales
        /// </summary>
        /// <param name="obj">Objeto a comparar con el objeto actual</param>
        /// <returns>Un booleano que indica si el objeto actual es igual al recibido como parámetro</returns>
        public override bool Equals(object? obj)
        {
            bool result;

            CandidaturaDTO? dTO = obj as CandidaturaDTO;

            if (dTO == null)
            {
                result = false;
            }
            else
            {
                result = (
                    dTO.Id == this.Id &&
                    dTO.Name == this.Name &&
                    dTO.Votes == this.Votes
                    );
            }

            return result;
        }

        /// <summary>
        /// Devuelve una cadena representativa del objeto actual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Votes: {this.Votes}";
        }

        #endregion Public Methods

    }
}
