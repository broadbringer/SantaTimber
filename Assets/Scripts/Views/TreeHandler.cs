using System.Collections.Generic;
using Customization;
using SantaTimber.Views;
using Unity.Mathematics;
using UnityEngine;


namespace SantaTimber.Controllers
{
    public class TreeHandler: MonoBehaviour
    {
        [SerializeField] private List<TreePartView> _treePartsPrefabs;
        private Queue<TreePartView> _tree;

        private int _currentTreePartOrder = 1;
        private Vector3 _nextPartPosition; 
        private void Start()
        {
            _tree = new Queue<TreePartView>(); 
            CreateStartTree();
        }

        private void CreateNewPart(Vector3 position, int prefabIndex)
        {
            var tempPart = Instantiate(_treePartsPrefabs[prefabIndex], new Vector3(), Quaternion.identity, transform);
            tempPart.transform.localPosition = position;
            tempPart._sprite.sortingOrder = _currentTreePartOrder;
            _tree.Enqueue(tempPart);
        }

        private void DestroyPart()
        {
            var destroyedPart = _tree.Dequeue();
            destroyedPart.OnHit();
        }

        private void CreateStartTree()
        {
            var position = new Vector3();
            var randomValue = new System.Random();
            var value = 1;
            for (var i = 0; i < 10; i++)
            {
                CreateNewPart(position, value);
                var newPosition = position.y + Constants.TreePart.SpriteHeight;
                position.y = newPosition;
                value = randomValue.Next(0, 3);
                _currentTreePartOrder++;
            }
        }
    }
    
}

