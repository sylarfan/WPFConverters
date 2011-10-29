namespace Kent.Boogaart.Converters.Expressions.Nodes
{
    //a node to check whether the left node is equal to the right node
    internal sealed class EqualityNode : WideningBinaryNode
    {
        protected override string OperatorSymbols
        {
            get
            {
                return "==";
            }
        }

        public EqualityNode(Node leftNode, Node rightNode)
            : base(leftNode, rightNode)
        {
        }

        protected override bool IsSupported(NodeValueType leftNodeValueType, NodeValueType rightNodeValueType)
        {
            return true;
        }

        protected override object DoString(string value1, string value2)
        {
            return value1 == value2;
        }

        protected override object DoBoolean(bool value1, bool value2)
        {
            return value1 == value2;
        }

        protected override object DoByte(byte value1, byte value2)
        {
            return value1 == value2;
        }

        protected override object DoInt16(short value1, short value2)
        {
            return value1 == value2;
        }

        protected override object DoInt32(int value1, int value2)
        {
            return value1 == value2;
        }

        protected override object DoInt64(long value1, long value2)
        {
            return value1 == value2;
        }

        protected override object DoSingle(float value1, float value2)
        {
            return value1 == value2;
        }

        protected override object DoDouble(double value1, double value2)
        {
            return value1 == value2;
        }

        protected override object DoDecimal(decimal value1, decimal value2)
        {
            return value1 == value2;
        }

        protected override object DoValueType(object value1, object value2)
        {
            return object.Equals(value1, value2);
        }

        protected override object DoReferenceType(object value1, object value2)
        {
            return object.ReferenceEquals(value1, value2);
        }
    }
}
