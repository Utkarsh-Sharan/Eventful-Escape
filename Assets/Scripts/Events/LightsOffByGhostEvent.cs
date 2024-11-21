using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int _keysRequiredToTrigger;
    [SerializeField] private SoundType _soundType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>() != null && _keysRequiredToTrigger == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GetComponent<Collider>().enabled = false;
            GameService.Instance.GetSoundView().PlaySoundEffects(_soundType);
        }
    }
}