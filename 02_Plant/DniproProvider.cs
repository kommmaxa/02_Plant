namespace _02_Plant
{
    class DniproProvider : PartOperationProvider
    {
        public override void Cast(Part part)
        {
            part.mass += 10;
        }

        public override void Grind(Part part)
        {
            part.roughness -= 4;
        }

        public override void Paint(Part part)
        {
            part.color = "blue";
            part.name += "_processed_by_Dnipro";
        }
    }
}
