using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS.Data.Error
{
    public class DSErrorData
    {
        public Color Color { get; set; }

        public DSErrorData()
        {
            GenerateRandomColor();
        }

        private void GenerateRandomColor()
        {
            Color = new Color32(
                (byte) Random.Range(65,255),
                (byte) Random.Range(50, 175),
                (byte) Random.Range(50, 175),
                255
            );
        }
    }
}

