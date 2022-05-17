using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystemEditor : MonoBehaviour
{
    [Header("Default Settings")]
    public int m_Distance = 10;
    public short m_Angle = 90;

    public int m_CrossSections = 4;
    public int m_CrossSectionDivisions = 2;


    // Start is called before the first frame update
    void Start()
    {
        var NT = new Dictionary<char, string>(){
    {'F', "F+F-F-F+F"},
    {'A', "AA-[-A+A+A]+[+A-A-A]"},
    {'H', "DuHrHdB"},
    {'B', "ClBdBrH"},
    {'C', "BdClCuD"},
    {'D', "HrDuDlC"}
};
        LSystem l = new(m_Distance, m_Angle, m_CrossSections, m_CrossSectionDivisions);
        var s = l.Parse("F", 1, NT);
        Debug.Log(s);
        var t = l.Tokenize("FF[+F][-F]F(42)");
        var v = l.Turtle3D(t);
        LSystem.PrintList(v);
        l.Evaluate("F", 2, NT, true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
