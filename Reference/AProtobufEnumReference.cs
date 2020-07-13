﻿
namespace ALittle
{
    public class AProtobufEnumReference : AProtobufReferenceTemplate<AProtobufEnumElement>
    {
        public AProtobufEnumReference(ABnfElement element) : base(element) { }

        public override int GetDesiredIndentation(int offset, ABnfElement select)
        {
            ABnfElement parent = m_element.GetParent();
            if (parent is AProtobufMessageBodyElement)
                return parent.GetReference().GetDesiredIndentation(offset, null);
            return 0;
        }

        public override int GetFormateIndentation(int offset, ABnfElement select)
        {
            ABnfElement parent = m_element.GetParent();
            if (parent is AProtobufMessageBodyElement)
                return parent.GetReference().GetFormateIndentation(offset, null);
            return 0;
        }
    }
}

