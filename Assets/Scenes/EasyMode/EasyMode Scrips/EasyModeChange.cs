using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EasyModeChange : MonoBehaviour
{
    public GameObject OneTwoFour;
    public GameObject OneFourSeven;
    public GameObject OneFiveNine;
    public GameObject TwoThreeSix;
    public GameObject TwoFiveEight;
    public GameObject ThreeSixNine;
    public GameObject ThreeFiveSeven;
    public GameObject Null;

    private OneScript onescript;
    private TwoScript twoscript;
    private ThreeScript threescript;
    private FourScript fourscript;
    private FiveScript fivescript;
    private SixScript sixscript;
    private SevenScript sevenscript;
    private EightScript eightscript;
    private NineScript ninescript;

    public void Start()
    {
        OneTwoFour.SetActive(false);
        OneFourSeven.SetActive(false);
        OneFiveNine.SetActive(false);
        TwoThreeSix.SetActive(false);
        TwoFiveEight.SetActive(false);
        ThreeSixNine.SetActive(false);
        ThreeFiveSeven.SetActive(false);
        Null.SetActive(true);

        onescript = GameObject.Find("One").GetComponent<OneScript>();
        twoscript = GameObject.Find("Two").GetComponent<TwoScript>();
        threescript = GameObject.Find("Three").GetComponent<ThreeScript>();
        fourscript = GameObject.Find("Four").GetComponent<FourScript>();
        fivescript = GameObject.Find("Five").GetComponent<FiveScript>();
        sixscript = GameObject.Find("Six").GetComponent<SixScript>();
        sevenscript = GameObject.Find("Seven").GetComponent<SevenScript>();
        eightscript = GameObject.Find("Eight").GetComponent<EightScript>();
        ninescript = GameObject.Find("Nine").GetComponent<NineScript>();
    }

     public void Update()
     {


        //124
        if (onescript.one == false)
        {
            if (twoscript.two == false)
            {
                if (fourscript.four == false)
                {
                    OneTwoFour.SetActive(true);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        //147
        if (onescript.one == false)
        {
            if (fourscript.four == false)
            {
                if (sevenscript.seven == false)
                {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(true);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        //159
        if (onescript.one == false)
        {
            if (fivescript.five == false)
            {
                if (ninescript.nine == false)
                {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(true);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        //236
        if (twoscript.two == false)
        {
            if (threescript.three == false)
            {
                if (sixscript.six == false)
                {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(true);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        //258
        if(eightscript.eight == false)
        {
            if(fivescript.five == false)
            {
               if(twoscript.two == false)
               {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(true);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }     
            }
        }

        //369
        if (threescript.three == false)
        {
            if (sixscript.six == false)
            {
                if (ninescript.nine == false)
                {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(true);
                    ThreeFiveSeven.SetActive(false);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        //357
        if (threescript.three == false)
        {
            if (fivescript.five == false)
            {
                if (sevenscript.seven == false)
                {
                    OneTwoFour.SetActive(false);
                    OneFourSeven.SetActive(false);
                    OneFiveNine.SetActive(false);
                    TwoThreeSix.SetActive(false);
                    TwoFiveEight.SetActive(false);
                    ThreeSixNine.SetActive(false);
                    ThreeFiveSeven.SetActive(true);
                    Null.SetActive(false);

                    onescript.one = true;
                    twoscript.two = true;
                    threescript.three = true;
                    fourscript.four = true;
                    fivescript.five = true;
                    sixscript.six = true;
                    sevenscript.seven = true;
                    eightscript.eight = true;
                    ninescript.nine = true;
                }
            }
        }

        
     }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Map124")
        {
           onescript.touch = false;
           twoscript.touch = false;
           threescript.touch = true;
           fourscript.touch = false;
           fivescript.touch = true;
           sixscript.touch = true;
           sevenscript.touch = true;
           eightscript.touch = true;
           ninescript.touch = true;
        }
        if (other.gameObject.tag == "Map147")
        {
            onescript.touch = false;
            twoscript.touch = true;
            threescript.touch = true;
            fourscript.touch = false;
            fivescript.touch = true;
            sixscript.touch = true;
            sevenscript.touch = false;
            eightscript.touch = true;
            ninescript.touch = true;
        }
        if (other.gameObject.tag == "Map159")
        {
            onescript.touch = true;
            twoscript.touch = true;
            threescript.touch = false;
            fourscript.touch = true;
            fivescript.touch = false;
            sixscript.touch = true;
            sevenscript.touch = false;
            eightscript.touch = true;
            ninescript.touch = true;
        }
        if (other.gameObject.tag == "Map236")
        {
            onescript.touch = true;
            twoscript.touch = false;
            threescript.touch = false;
            fourscript.touch = true;
            fivescript.touch = true;
            sixscript.touch = false;
            sevenscript.touch = true;
            eightscript.touch = true;
            ninescript.touch = true;
        }
        if (other.gameObject.tag == "Map258")
        {
            onescript.touch = true;
            twoscript.touch = false;
            threescript.touch = true;
            fourscript.touch = true;
            fivescript.touch = false;
            sixscript.touch = true;
            sevenscript.touch = true;
            eightscript.touch = false;
            ninescript.touch = true;
        }
        if (other.gameObject.tag == "Map369")
        {
            onescript.touch = true;
            twoscript.touch = true;
            threescript.touch = false;
            fourscript.touch = true;
            fivescript.touch = true;
            sixscript.touch = false;
            sevenscript.touch = true;
            eightscript.touch = true;
            ninescript.touch = false;
        }
        if (other.gameObject.tag == "Map357")
        {
            onescript.touch = false;
            twoscript.touch = true;
            threescript.touch = true;
            fourscript.touch = true;
            fivescript.touch = false;
            sixscript.touch = true;
            sevenscript.touch = true;
            eightscript.touch = true;
            ninescript.touch = false;
        }
    }
 
}
           
 