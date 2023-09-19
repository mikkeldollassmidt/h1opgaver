namespace TheFirm2
{
    internal class GraphicDesigner: DataAnalyst
    {
        private bool _canDesign;

        public bool CanDesign
        {
            get { return _canDesign; }
            set { _canDesign = value; }
        }
    }
}
