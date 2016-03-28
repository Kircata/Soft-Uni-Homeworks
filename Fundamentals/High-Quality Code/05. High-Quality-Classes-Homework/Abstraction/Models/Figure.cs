﻿namespace Abstraction.Models
{
    using Contracts;

    public abstract class Figure : IFigure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
