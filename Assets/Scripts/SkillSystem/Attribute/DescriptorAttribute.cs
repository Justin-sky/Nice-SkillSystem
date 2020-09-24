using System;

namespace SkillSystem
{
    public class DescriptorAttribute : Attribute
    {
        private readonly string _desc;

        public string Desc
        {
            get { return this._desc; }
        }

        public DescriptorAttribute(string desc)
        {
            this._desc = desc;
        }
    }

}
