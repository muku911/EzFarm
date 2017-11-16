using UnityEngine;

public class UIControl : MonoBehaviour {
    public Canvas Ensiklo, BukuPanduan, Pakcopedia, Hama, UT, CiriUT,
        TndUT, PcgUT, MengUT, Gra, CiriGra, TndGra, PcgGra, MengGra,
        RD, CiriRD, TndRD, PcgRD, MengRD, LM, CiriLM, TndLM, PcgLM, 
        MengLM, Penyakit, AkrGda, GejGda, PcgGda, MengGda, BskDwn,
        GejDwn, PcgDwn, MengDwn;
    public Button buttn;

	// Use this for initialization
	void Start () {
        /*BukuPanduan = BukuPanduan.GetComponent<Canvas>();
        Pakcopedia = Pakcopedia.GetComponent<Canvas>();
        Hama = Hama.GetComponent<Canvas>();
        UT = UT.GetComponent<Canvas>();
        CiriUT = CiriUT.GetComponent<Canvas>();
        TndUT = TndUT.GetComponent<Canvas>();
        PcgUT = PcgUT.GetComponent<Canvas>();
        MengUT = MengUT.GetComponent<Canvas>();
        Gra = Gra.GetComponent<Canvas>();
        CiriGra = CiriGra.GetComponent<Canvas>();
        TndGra = TndGra.GetComponent<Canvas>();
        PcgGra = PcgGra.GetComponent<Canvas>();
        MengGra = MengGra.GetComponent<Canvas>();
        RD = RD.GetComponent<Canvas>();
        CiriRD = CiriRD.GetComponent<Canvas>();
        TndRD = TndRD.GetComponent<Canvas>();
        PcgRD = PcgRD.GetComponent<Canvas>();
        MengRD = MengRD.GetComponent<Canvas>();
        LM = LM.GetComponent<Canvas>();
        CiriLM = CiriLM.GetComponent<Canvas>();
        TndLM = TndLM.GetComponent<Canvas>();
        PcgLM = PcgLM.GetComponent<Canvas>();
        MengLM = MengLM.GetComponent<Canvas>();
        Penyakit = Penyakit.GetComponent<Canvas>();
        AkrGda = AkrGda.GetComponent<Canvas>();
        GejGda = GejGda.GetComponent<Canvas>();
        PcgGda = PcgGda.GetComponent<Canvas>();
        MengGda = MengGda.GetComponent<Canvas>();
        BskDwn = BskDwn.GetComponent<Canvas>();
        GejDwn = GejDwn.GetComponent<Canvas>();
        PcgDwn = PcgDwn.GetComponent<Canvas>();
        MengDwn = MengDwn.GetComponent<Canvas>();

        closebtn = closebtn.GetComponent<Button>();*/
        buttn = buttn.GetComponent<Button>();

        BukuPanduan.enabled = false;
        Pakcopedia.enabled = false;
        Hama.enabled = false;
        UT.enabled = false;
        CiriUT.enabled = false;
        TndUT.enabled = false;
        PcgUT.enabled = false;
        MengUT.enabled = false;
        Gra.enabled = false;
        CiriGra.enabled = false;
        TndGra.enabled = false;
        PcgGra.enabled = false;
        MengGra.enabled = false;
        RD.enabled = false;
        CiriRD.enabled = false;
        TndRD.enabled = false;
        PcgRD.enabled = false;
        MengRD.enabled = false;
        LM.enabled = false;
        CiriLM.enabled = false;
        TndLM.enabled = false;
        PcgLM.enabled = false;
        MengLM.enabled = false;
        Penyakit.enabled = false;
        AkrGda.enabled = false;
        GejGda.enabled = false;
        PcgGda.enabled = false;
        MengGda.enabled = false;
        BskDwn.enabled = false;
        GejDwn.enabled = false;
        PcgDwn.enabled = false;
        MengDwn.enabled = false;
    }
	
    public void butt()
    {
        BukuPanduan.enabled = true;
        buttn.enabled = false;
    }

    public void Pakcoped ()
    {
        BukuPanduan.enabled = false;
        Pakcopedia.enabled = true;
    }

    public void hama()
    {
        Hama.enabled = true;
        BukuPanduan.enabled = false;
    }

    public void close() {
        BukuPanduan.enabled = false;
        Pakcopedia.enabled = false;
        Hama.enabled = false;
        UT.enabled = false;
        CiriUT.enabled = false;
        TndUT.enabled = false;
        PcgUT.enabled = false;
        MengUT.enabled = false;
        Gra.enabled = false;
        CiriGra.enabled = false;
        TndGra.enabled = false;
        PcgGra.enabled = false;
        MengGra.enabled = false;
        RD.enabled = false;
        CiriRD.enabled = false;
        TndRD.enabled = false;
        PcgRD.enabled = false;
        MengRD.enabled = false;
        LM.enabled = false;
        CiriLM.enabled = false;
        TndLM.enabled = false;
        PcgLM.enabled = false;
        MengLM.enabled = false;
        Penyakit.enabled = false;
        AkrGda.enabled = false;
        GejGda.enabled = false;
        PcgGda.enabled = false;
        MengGda.enabled = false;
        BskDwn.enabled = false;
        GejDwn.enabled = false;
        PcgDwn.enabled = false;
        MengDwn.enabled = false;
        //Ensiklo.enabled = false;
    }
}
