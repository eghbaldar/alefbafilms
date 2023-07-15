using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.domian.Commons
{
    /// <summary>
    /// Whenever any "Entities" will be inherited from this class, this class properties
    /// [Id,InserTime,UpdateTime,DeleteTime], will be added to that "Entity".
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class BaseEntity<TKey>
    {
        /// <summary>
        /// This field [Id] will be added to the entity, so remove the ID of that entity!
        /// </summary>
        //public TKey Id { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
    /// <summary>
    /// This function will clarify what kind of datatype the Id has.
    /// </summary>
    public abstract class BaseEntity : BaseEntity<long>
    {
    }
}
