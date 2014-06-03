﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moddingSuite.Model.Common;

namespace moddingSuite.Model.Scenario
{
    public class AreaContent
    {
        private List<AreaClipped> _clippedAreas  = new List<AreaClipped>();
        private AreaClipped _borderTriangle = new AreaClipped();
        private AreaClipped _borderVertex = new AreaClipped();

        private List<AreaVertex> _vertices = new List<AreaVertex>();
        private List<MeshTriangularFace> _triangles = new List<MeshTriangularFace>(); 

        public List<AreaClipped> ClippedAreas
        {
            get { return _clippedAreas; }
            set { _clippedAreas = value; }
        }

        public AreaClipped BorderTriangle
        {
            get { return _borderTriangle; }
        }

        public AreaClipped BorderVertex
        {
            get { return _borderVertex; }
        }

        public List<AreaVertex> Vertices
        {
            get { return _vertices; }
        }

        public List<MeshTriangularFace> Triangles
        {
            get { return _triangles; }
        }
    }
}
