using UnityEngine;
using UnityEngine.UI;  // �ǉ�

public class SelectLoop : MonoBehaviour
{
  // �ŏ��̃t���[���X�V�̑O�ɊJ�n���Ăяo����܂�
  void Start()
  {
    // �{�^���ȂǑI���\�ȃR���|�[�l���g���擾����
    var selects = GetComponentsInChildren<Selectable>();
    for (var i = 0; i < selects.Length; i++)
    {
      var nav = selects[i].navigation;
      nav.mode = Navigation.Mode.Explicit;
      nav.selectOnUp = selects[i == 0 ? selects.Length - 1 : i - 1];
      nav.selectOnDown = selects[(i + 1) % selects.Length];
      selects[i].navigation = nav;
    }
  }

  // �X�V�̓t���[�����Ƃ�1��Ăяo����܂�
  void Update() { }
}
