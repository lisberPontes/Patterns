using System;
using System.Text;

namespace BuilderPattern.Entities
{
    /// <summary>
    /// Represents a 'complex object'
    /// This object as an order on the way it needs to be built. Thus:
    /// Firstly, a foundation must be defined
    /// Secondly, a structure must be provided
    /// Lastly, a roof must be provided
    /// </summary>
    internal sealed class House
    {
        private string _foundation = null;
        /// <summary>
        /// The title header
        /// </summary>
        public string Foundation {
            get => _foundation;
            set => _foundation = value ?? throw new ArgumentNullException(nameof(Foundation));
        }

        private string _structure = string.Empty;

        /// <summary>
        /// The structure of the house.
        /// </summary>
        public string Structure
        {
            get => _structure;
            set
            {
                // The foundation must be set prior to the structure
                if (_foundation == null)
                {
                    throw new ArgumentNullException(nameof(_foundation));
                }
                _structure = value ?? throw new ArgumentNullException(nameof(_structure));
            }
        }

        private string _roof = null;

        /// <summary>
        /// The creation of the roof
        /// </summary>
        public string Roof
        {
            get => _roof;
            set
            {
                // The foundation must be set prior to the roof
                if (_foundation == null)
                {
                    throw new ArgumentNullException(nameof(_foundation));
                }

                // The structure must be set prior to the roof
                if (_structure == null)
                {
                    throw new ArgumentNullException(nameof(_structure));
                }

                _roof = value ?? throw new ArgumentNullException(nameof(_roof));
            }
        }

        /// <summary>
        /// Renders the report.
        /// </summary>
        /// <returns></returns>
        public string DisplayHouse()
        {
            return new StringBuilder()
                .AppendLine(Foundation)
                .AppendLine(Structure)
                .AppendLine(Roof)
                .ToString();
        }
    }
}