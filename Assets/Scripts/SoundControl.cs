using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource cerebrum,cerebellum,brainstem,head,eye,ear,
        nose,neck,shoulder,chest,arm,belly,leg,foot, ateries, pulmonaryVeins, rightAtrium, leftAtrium, rightVentrical,leftVentrical;
    public RaycastHit _hit;

    private void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));


        if (Physics.Raycast(ray, out _hit, 5))
        {
            switch(_hit.collider.gameObject.name)
            {
                case "Brain_Part_06":
                    cerebrum.Play();
                    break;
                case "Brain_Part_02":
                    cerebellum.Play();
                    break;
                case "Brain_Part_05":
                    brainstem.Play();
                    break;
                case "Head":
                    head.Play();
                    break;
                case "Eye":
                    eye.Play();
                    break;
                case "Ear":
                    ear.Play();
                    break;
                case "Nose":
                    nose.Play();
                    break;
                case "Neck":
                    neck.Play();
                    break;
                case "Shoulder":
                    shoulder.Play();
                    break;
                case "Chest":
                    chest.Play();
                    break;
                case "Arm":
                    arm.Play();
                    break;
                case "Belly":
                    belly.Play();
                    break;
                case "Leg":
                    leg.Play();
                    break;
                case "Foot":
                    foot.Play();
                    break;
                case "Ateries":
                    ateries.Play();
                    break;
                case "Pulmonary Veins":
                    pulmonaryVeins.Play();
                    break;
                case "Right Atrium":
                    rightAtrium.Play();
                    break;
                case "Right Ventrical":
                    rightVentrical.Play();
                    break;
                case "Left Atrium":
                    leftAtrium.Play();
                    break;
                case "Left Ventrical":
                    leftVentrical.Play();
                    break;
            }
        }
    }
}
