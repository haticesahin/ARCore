using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject CisimlerPnl, HarflerPnl, SayilarPnl, HayvanlarPnl;

    public void CisimPnl_Active()
    {
        if(CisimlerPnl != null)
        {
            bool isActive = CisimlerPnl.activeSelf;
            CisimlerPnl.SetActive(!isActive);
        }   
    }

    public void HarflerPnl_Active()
    {
        if (HarflerPnl != null)
        {
            bool isActive = HarflerPnl.activeSelf;
            HarflerPnl.SetActive(!isActive);
        }
    }

    public void SayilarPnl_Active()
    {
        if (SayilarPnl != null)
        {
            bool isActive = SayilarPnl.activeSelf;
            SayilarPnl.SetActive(!isActive);
        }
    }

    public void HayvanlarPnl_Active()
    {
        if (HayvanlarPnl != null)
        {
            bool isActive = HayvanlarPnl.activeSelf;
            HayvanlarPnl.SetActive(!isActive);
        }
    }
}
