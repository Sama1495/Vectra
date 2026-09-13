using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    public float fireRate = 0.3f;
    public InputActionReference triggerAction;
    private float nextFireTime;

    // Esto activa el botón para que las Quest lo reconozcan
    private void OnEnable() => triggerAction?.action.Enable();
    private void OnDisable() => triggerAction?.action.Disable();

    void Update()
    {
        if (triggerAction == null || bulletPrefab == null || muzzle == null) return;

        // Lee el gatillo (0 es suelto, 1 es apretado a fondo)
        float triggerValue = triggerAction.action.ReadValue<float>();

        if (triggerValue > 0.5f && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
    }
}