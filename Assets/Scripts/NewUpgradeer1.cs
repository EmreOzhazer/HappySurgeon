using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewUpgradeer1 : MonoBehaviour, IDropHandler
{
    //Detect collisions between the GameObjects with Colliders attached
    public bool dropped = false;
    NewUpgradeer1 newUpgradeer;
    TimeBar timeBar;
    string colliderName;
    GameManager gm;
    Audio audio;

    public GameObject RibsBoneDamaged;
    public GameObject TorsoBoneDamaged;
    public GameObject PelvisBoneDamaged;
    public GameObject UpperRightLegDamaged;
    public GameObject UpperLeftLegDamaged;
    public GameObject LowerRightLegDamaged;
    public GameObject LowerLeftLegDamaged;
    public GameObject RightHandDamaged;
    public GameObject LeftHandDamaged;
    public GameObject LowerRightArmDamaged;
    public GameObject LowerLeftArmDamaged;
    public GameObject UpperRightArmDamaged;
    public GameObject UpperLeftArmDamaged;
    public GameObject SkullDamaged;
    public GameObject LeftFootDamaged;
    public GameObject RightFootDamaged;
    public GameObject RibsBone;
    public GameObject PelvisBone;
    public GameObject TorsoBone;
    public GameObject UpperRightLeg;
    public GameObject UpperLeftLeg;
    public GameObject LowerRightLeg;
    public GameObject LowerLeftLeg;
    public GameObject RightHand;
    public GameObject LeftHand;
    public GameObject LowerRightArm;
    public GameObject LowerLeftArm;
    public GameObject UpperRightArm;
    public GameObject UpperLeftArm;
    public GameObject Skull;
    public GameObject LeftFoot;
    public GameObject RightFoot;

    public string tagName;
    public int fixedBoneAmount;

    public void buttonVisible()
    {
        //button.SetActive(true);
    }
    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(2);
        buttonVisible();
    }
    private void Start()
    {
        timeBar = FindObjectOfType<TimeBar>();
        gm = FindObjectOfType<GameManager>();
        //audio = FindObjectOfType<Audio>();
        //audio.pointearned = Resources.Load<AudioClip>("pointearned");
        //audio.audioSrc = GetComponent<AudioSource>();
    }
    #region 
    IEnumerator TimeDelayForLimb(int kind)
    {
        if (kind == 1)
        {
            
            yield return new WaitForSeconds(2);
            RibsBone.SetActive(false);
            RibsBone.transform.position = RibsBoneDamaged.transform.position;
            RibsBone.SetActive(true);
            
        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            RibsBoneDamaged.SetActive(false);
            RibsBone.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            // audio.audioSrc.PlayOneShot(audio.pointearned);
            Audio.UpgraderSound("pointearned");
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }


    IEnumerator TimeDelayForLimb2(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            TorsoBone.SetActive(false);
            TorsoBone.transform.position = TorsoBoneDamaged.transform.position;
            TorsoBone.SetActive(true);
        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            TorsoBoneDamaged.SetActive(false);
            TorsoBone.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            Audio.UpgraderSound("pointearned");
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }


    IEnumerator TimeDelayForLimb3(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            PelvisBone.SetActive(false);
            PelvisBone.transform.position = PelvisBoneDamaged.transform.position;
            PelvisBone.SetActive(true);
        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            PelvisBoneDamaged.SetActive(false);
            PelvisBone.SetActive(true);
            gm.infoFlag++; 
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }

    IEnumerator TimeDelayForLimb4(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            UpperRightLeg.SetActive(false);
            UpperRightLeg.transform.position = UpperRightLegDamaged.transform.position;
            UpperRightLeg.SetActive(true);
        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            UpperRightLegDamaged.SetActive(false);
            UpperRightLeg.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            fixedBoneAmount++;
            ScoreCounter.scoreValue += 10;
        }
    }
    IEnumerator TimeDelayForLimb5(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            UpperLeftLeg.SetActive(false);
            UpperLeftLeg.transform.position = UpperLeftLegDamaged.transform.position;
            UpperLeftLeg.SetActive(true);
        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            UpperLeftLegDamaged.SetActive(false);
            UpperLeftLeg.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb6(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LowerLeftLeg.SetActive(false);
            LowerLeftLeg.transform.position = LowerLeftLegDamaged.transform.position;
            LowerLeftLeg.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LowerLeftLegDamaged.SetActive(false);
            LowerLeftLeg.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }

    IEnumerator TimeDelayForLimb7(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LowerRightLeg.SetActive(false);
            LowerRightLeg.transform.position = LowerRightLegDamaged.transform.position;
            LowerRightLeg.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LowerRightLegDamaged.SetActive(false);
            LowerRightLeg.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb8(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            RightHand.SetActive(false);
            RightHand.transform.position = RightHandDamaged.transform.position;
            RightHand.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            RightHandDamaged.SetActive(false);
            RightHand.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb9(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LeftHand.SetActive(false);
            LeftHand.transform.position = LeftHandDamaged.transform.position;
            LeftHand.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LeftHandDamaged.SetActive(false);
            LeftHand.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb10(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LowerRightArm.SetActive(false);
            LowerRightArm.transform.position = LowerRightArmDamaged.transform.position;
            LowerRightArm.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LowerRightArmDamaged.SetActive(false);
            LowerRightArm.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }

    IEnumerator TimeDelayForLimb11(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LowerLeftArm.SetActive(false);
            LowerLeftArm.transform.position = LowerLeftArmDamaged.transform.position;
            LowerLeftArm.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LowerLeftArmDamaged.SetActive(false);
            LowerLeftArm.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }

    IEnumerator TimeDelayForLimb12(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            UpperRightArm.SetActive(false);
            UpperRightArm.transform.position = UpperRightArmDamaged.transform.position;
            UpperRightArm.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            UpperRightArmDamaged.SetActive(false);
            UpperRightArm.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb13(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            UpperLeftArm.SetActive(false);
            UpperLeftArm.transform.position = UpperLeftArmDamaged.transform.position;
            UpperLeftArm.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            UpperLeftArmDamaged.SetActive(false);
            UpperLeftArm.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb14(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            LeftFoot.SetActive(false);
            LeftFoot.transform.position = LeftFootDamaged.transform.position;
            LeftFoot.SetActive(true);


        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            LeftFootDamaged.SetActive(false);
            LeftFoot.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    IEnumerator TimeDelayForLimb15(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            RightFoot.SetActive(false);
            RightFoot.transform.position = RightFootDamaged.transform.position;
            RightFoot.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            RightFootDamaged.SetActive(false);
            RightFoot.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }

    IEnumerator TimeDelayForLimb16(int kind)
    {
        if (kind == 1)
        {
            yield return new WaitForSeconds(2);
            Skull.SetActive(false);
            Skull.transform.position = SkullDamaged.transform.position;
            Skull.SetActive(true);

        }
        else if (kind == 2)
        {
            timeBar.AnimateBar();
            yield return new WaitForSeconds(2);
            SkullDamaged.SetActive(false);
            Skull.SetActive(true);
            gm.infoFlag++;
            timeBar.StopBar();
            ScoreCounter.scoreValue += 10;
            fixedBoneAmount++;
        }
    }
    #endregion

    public void buttonNotVisible()
    {
        //button.SetActive(false);
    }
    public void isDropped()
    {
        dropped = true;
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        if (dropped == true && eventData.pointerDrag != null)
        {

            //Debug.Log("OnDrop");
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            StartCoroutine(TimeDelay());


            switch (tagName)
            {
                case "Ribs":
                    if (colliderName == "RibsBone")
                        StartCoroutine((TimeDelayForLimb(1)));
                        
                    else if (colliderName == "RibsBoneDamaged")
                        StartCoroutine((TimeDelayForLimb(2)));
                    
                    break;

                case "Torso":
                    if (colliderName == "TorsoBone")
                        StartCoroutine((TimeDelayForLimb2(1)));
                    else if (colliderName == "TorsoBoneDamaged")
                        StartCoroutine((TimeDelayForLimb2(2)));
                    break;

                case "Pelvis":
                    if (colliderName == "PelvisBone")
                        StartCoroutine((TimeDelayForLimb3(1)));
                    else if (colliderName == "PelvisBoneDamaged")
                        StartCoroutine((TimeDelayForLimb3(2)));
                    break;

                case "UpperRightLeg":
                    if (colliderName == "UpperRightLeg")
                        StartCoroutine((TimeDelayForLimb4(1)));
                    else if (colliderName == "UpperRightLegDamaged")
                        StartCoroutine((TimeDelayForLimb4(2)));
                    break;

                case "UpperLeftLeg":
                    if (colliderName == "UpperLeftLeg")
                        StartCoroutine((TimeDelayForLimb5(1)));
                    else if (colliderName == "UpperLeftLegDamaged")
                        StartCoroutine((TimeDelayForLimb5(2)));
                    break;

                case "LowerLeftLeg":
                    if (colliderName == "LowerLeftLeg")
                        StartCoroutine((TimeDelayForLimb6(1)));
                    else if (colliderName == "LowerLeftLegDamaged")
                        StartCoroutine((TimeDelayForLimb6(2)));
                    break;
                case "LowerRightLeg":
                    if (colliderName == "LowerRightLeg")
                        StartCoroutine((TimeDelayForLimb7(1)));
                    else if (colliderName == "LowerRightLegDamaged")
                        StartCoroutine((TimeDelayForLimb7(2)));
                    break;
                case "RightHand":
                    if (colliderName == "RightHand")
                        StartCoroutine((TimeDelayForLimb8(1)));
                    else if (colliderName == "RightHandDamaged")
                        StartCoroutine((TimeDelayForLimb8(2)));
                    break;
                case "LeftHand":
                    if (colliderName == "LeftHand")
                        StartCoroutine((TimeDelayForLimb9(1)));
                    else if (colliderName == "LeftHandDamaged")
                        StartCoroutine((TimeDelayForLimb9(2)));
                    break;
                case "LowerRightArm":
                    if (colliderName == "LowerRightArm")
                        StartCoroutine((TimeDelayForLimb10(1)));
                    else if (colliderName == "LowerRightArmDamaged")
                        StartCoroutine((TimeDelayForLimb10(2)));
                    break;
                case "LowerLeftArm":
                    if (colliderName == "LowerLeftArm")
                        StartCoroutine((TimeDelayForLimb11(1)));
                    else if (colliderName == "LowerLeftArmDamaged")
                        StartCoroutine((TimeDelayForLimb11(2)));
                    break;
                case "UpperRightArm":
                    if (colliderName == "UpperRightArm")
                        StartCoroutine((TimeDelayForLimb12(1)));
                    else if (colliderName == "UpperRightArmDamaged")
                        StartCoroutine((TimeDelayForLimb12(2)));
                    break;
                case "UpperLeftArm":
                    if (colliderName == "UpperLeftArm")
                        StartCoroutine((TimeDelayForLimb13(1)));
                    else if (colliderName == "UpperLeftArmDamaged")
                        StartCoroutine((TimeDelayForLimb13(2)));
                    break;
                case "LeftFoot":
                    if (colliderName == "LeftFoot")
                        StartCoroutine((TimeDelayForLimb14(1)));
                    else if (colliderName == "LeftFootDamaged")
                        StartCoroutine((TimeDelayForLimb14(2)));
                    break;
                case "RightFoot":
                    if (colliderName == "RightFoot")
                        StartCoroutine((TimeDelayForLimb15(1)));
                    else if (colliderName == "RightFootDamaged")
                        StartCoroutine((TimeDelayForLimb15(2)));
                    break;
                case "Skull":
                    if (colliderName == "Skull")
                        StartCoroutine((TimeDelayForLimb16(1)));
                    else if (colliderName == "SkullDamaged")
                        StartCoroutine((TimeDelayForLimb16(2)));
                    break;

            }

        }
    }

    public void OnTriggerEnter(Collider collider)
    {

        Debug.Log("Slots Matched.");

        isDropped();

        tagName = collider.tag;
        colliderName = collider.name;
        Debug.Log(colliderName);

    }
}
