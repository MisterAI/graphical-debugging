﻿//------------------------------------------------------------------------------
// <copyright file="GeometryItem.cs">
//     Copyright (c) Adam Wulkiewicz.
// </copyright>
//------------------------------------------------------------------------------

using System.Windows.Media;

namespace GraphicalDebugging
{
    class GeometryItem : VariableItem
    {
        public GeometryItem(int colorId, Colors colors)
            : base()
        {
            SetColor(colorId, colors);
        }

        public GeometryItem(ExpressionDrawer.IDrawable drawable,
                            Geometry.Traits traits,
                            string name, string type, int colorId, Colors colors)
            : base(name, null, type)
        {
            SetColor(colorId, colors);
            Drawable = drawable;
            Traits = traits;
        }

        private int colorId;
        public int ColorId
        {
            get { return colorId; }
        }

        private Color color;
        public Color Color
        {
            get { return color; }
        }

        private void SetColor(int colorId, Colors colors)
        {
            this.colorId = colorId;
            color = Util.ConvertColor(colors[colorId]);
        }

        private ExpressionDrawer.IDrawable drawable;
        public ExpressionDrawer.IDrawable Drawable
        {
            get { return this.drawable; }
            set { this.drawable = value; }
        }

        private Geometry.Traits traits;
        public Geometry.Traits Traits
        {
            get { return this.traits; }
            set { this.traits = value; }
        }
    }
}
