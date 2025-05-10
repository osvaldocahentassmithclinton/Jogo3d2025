using UnityEngine;

public class MirrorObjectY : MonoBehaviour
{
    public Transform targetToMirror; // arraste o ch�o aqui
    public float offsetY = 5f;       // altura do teto em rela��o ao ch�o

    void Start()
    {
        if (targetToMirror == null)
        {
            Debug.LogError("Atribua o objeto que ser� espelhado.");
            return;
        }

        // Cria uma c�pia
        GameObject mirrored = Instantiate(targetToMirror.gameObject);

        // Nome �til
        mirrored.name = targetToMirror.name + "_Mirrored";

        // Inverte no eixo Y com rota��o
        mirrored.transform.rotation = targetToMirror.rotation * Quaternion.Euler(180, 0, 0);

        // Mant�m escala original
        mirrored.transform.localScale = targetToMirror.localScale;

        // Coloca no alto, espelhado em rela��o � posi��o original
        Vector3 originalPos = targetToMirror.position;
        mirrored.transform.position = new Vector3(originalPos.x, originalPos.y + offsetY, originalPos.z);
    }
}
