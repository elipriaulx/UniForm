using System.Collections.Generic;

namespace UniForm.Engine.Forms
{
    public class UniFormRoot : UniFormObjectBase
    {
        internal UniFormRoot(UniFormField[] fields, string name = null, string description = null)
        {
            _fields = fields;
            Name = name;
            Description = description;
        }

        private UniFormField[] _fields;

        public string Name { get; }

        public string Description { get; }

        public IEnumerable<UniFormField> Fields => _fields;

        public void ForceRead()
        {
            foreach (var f in _fields) f.ForceRead();
        }

        public void ForceWrite()
        {
            foreach (var f in _fields) f.ForceWrite();
        }
    }
}
