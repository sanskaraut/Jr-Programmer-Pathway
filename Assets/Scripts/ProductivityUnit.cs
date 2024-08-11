using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ProductivityUnit : Unit
{
    private ResourcePile m_CurrentPile = null;
    private float Productivitumultiplyer = 2;
    // Start is called before the first frame update
    protected override void BuildingInRange()
    {
        if(m_CurrentPile == null)
        {
            ResourcePile pile = m_Target as ResourcePile;
        
            if(pile != null)
            {
                m_CurrentPile = pile;
                m_CurrentPile.ProductionSpeed *= Productivitumultiplyer; 
            }
        
        }
        
    }
    protected void ResetResourcePile()
    {
        if(m_CurrentPile != null)
        {
            m_CurrentPile.ProductionSpeed /= Productivitumultiplyer;
            m_CurrentPile = null;
        }
    }
    public override void GoTo(Building target)
    {
        ResetResourcePile();
        base.GoTo(target);
    }
    public override void GoTo(Vector3 position)
    {
        ResetResourcePile();
        base.GoTo(position);
    }
}
