using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticsLab
{
    class GeneSequence
    {
        public GeneSequence(string name, string sequence)
        {
            m_name = name;
            m_sequence = sequence;
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public string Sequence
        {
            get
            {
                return m_sequence;
            }
        }

        private string m_name, m_sequence;
    }
}
