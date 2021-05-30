using System;
using System.Collections.Generic;
using System.Text;

namespace BoxTask
{
    class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Width));

                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double CalcVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double CalcLateralSurfaceArea() 
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double CalcSurfaceArea() 
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height + 
                2 * this.Length * this.Width;
        }

        private void ThrowIfInvalidSide(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} cannot be zero or negative.");
            }
        }
    }
}
