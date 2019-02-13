using System.Runtime.Serialization;

namespace TestBusinessLogic.Models
{
    [DataContract]
    public class TestModel
    {
        /// <summary>
        /// The Primary Identifier of the TestModel
        /// </summary>
        [DataMember(Order = 1)]
        public int ID { get; set; }
        /// <summary>
        /// The TestModel's first name
        /// </summary>
        [DataMember(Order = 2)]
        public string FirstName { get; set; }
        /// <summary>
        /// The TestModel's Last name
        /// </summary>
        [DataMember(Order = 3)]
        public string LastName { get; set; }
        /// <summary>
        /// The TestModel's mobile phone number
        /// </summary>
        [DataMember(Order = 4)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Copies the attributes of the given model to this one.
        /// </summary>
        /// <param name="model"></param>
        public void Update(TestModel model)
        {
            this.ID = model.ID;
            this.FirstName = model.FirstName;
            this.LastName = model.LastName;
            this.PhoneNumber = model.PhoneNumber;
        }

        /// <summary>
        /// Determines if the object in question is equal to this one.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                TestModel m = (TestModel)obj;

                return this.ID == m.ID
                    && this.FirstName == m.FirstName
                    && this.LastName == m.LastName
                    && this.PhoneNumber == m.PhoneNumber;
            }
        }

        /// <summary>
        /// Returns the ID of the TestModel
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => ID;
    }
}
