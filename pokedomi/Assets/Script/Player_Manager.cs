using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public Vector3 clickPos;

    [SerializeField] Camera mainCam;//メインカメラ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClickScreen()
    {
        //マウスのスクリーン座標をワールド座標に変換するためのRayを作成
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        //RaycastHitを使用して、クリックした位置のワールド座標を取得
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            //Rayがヒットしたオブジェクトのタグが"Ground"の場合のみ、クリックした位置を保存する
            if (hit.collider.gameObject.tag == "Untagged")
            {
                //Rayがヒットした位置をクリックした位置として保存
                clickPos = hit.point;
            }
        }
    }
}
