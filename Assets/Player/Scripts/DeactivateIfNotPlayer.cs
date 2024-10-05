using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DeactivateIfNotPlayer : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (!IsLocalPlayer)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
