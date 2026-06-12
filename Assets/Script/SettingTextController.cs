using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingTextController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler //IPointerEnterHandler와 IPointerExitHandler | 인터페이스 | 마우스 포인터가 UI에 들어오거나 나갈 때의 이벤트 처리.
{
    [SerializeField] Vector3 normalSize = new Vector3(0.9f, 0.9f, 0.9f); //원래(normal) 텍스트 크기
    [SerializeField] Vector3 hoverSize = new Vector3(1.0f, 1.0f, 1.0f); //클래스 은닉성을 사용한 마우스를 텍스트 위에 올려놓았을 때(hover)의 크기
    // 값을 쉽게 바꾸기 위해서 [SerializeField]를 사용하여 인스펙터에서 크기를 조절할 수 있도록 함
    // 코드 내에서 값을 수정해도 인스펙터에서 설정한 값이 우선적으로 적용됨. 주의요망
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData) // IPointerEnterHandler 인터페이스의 메서드로, 마우스가 텍스트 위에 올라갔을 때 호출됨
    {
        transform.localScale = hoverSize; // 마우스가 텍스트 위에 올라갔을 때 텍스트 크기를 hoverSize로 변경
    }

    public void OnPointerExit(PointerEventData eventData) // IPointerExitHandler 인터페이스의 메서드로, 마우스가 텍스트에서 벗어났을 때 호출됨
    {
        transform.localScale = normalSize; // 마우스가 텍스트에서 벗어났을 때 텍스트 크기를 normalSize로 변경
    }
}
