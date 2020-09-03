using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HardModeChange : MonoBehaviour
{
    public GameObject OneTwoFour;
    public GameObject OneFourSeven;
    public GameObject OneFiveNine;
    public GameObject TwoThreeSix;
    public GameObject TwoFiveEight;
    public GameObject ThreeSixNine;
    public GameObject ThreeFiveSeven;
    public GameObject Null;

    private OneScript1 onescript;
    private TwoScript1 twoscript;
    private ThreeScript1 threescript;
    private FourScript1 fourscript;
    private FiveScript1 fivescript;
    private SixScript1 sixscript;
    private SevenScript1 sevenscript;
    private EightScript1 eightscript;
    private NineScript1 ninescript;

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

        onescript = GameObject.Find("One").GetComponent<OneScript1>();
        twoscript = GameObject.Find("Two").GetComponent<TwoScript1>();
        threescript = GameObject.Find("Three").GetComponent<ThreeScript1>();
        fourscript = GameObject.Find("Four").GetComponent<FourScript1>();
        fivescript = GameObject.Find("Five").GetComponent<FiveScript1>();
        sixscript = GameObject.Find("Six").GetComponent<SixScript1>();
        sevenscript = GameObject.Find("Seven").GetComponent<SevenScript1>();
        eightscript = GameObject.Find("Eight").GetComponent<EightScript1>();
        ninescript = GameObject.Find("Nine").GetComponent<NineScript1>();
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
}
           
 