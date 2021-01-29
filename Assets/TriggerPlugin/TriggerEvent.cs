using System;
using UnityEngine;
using UnityEngine.Events;

namespace TriggerPlugin
{
    public class TriggerEvent : MonoBehaviour
    {
        public UnityEvent<GameObject> getGameObject;
        [TagWrapper] public string[] tagsToCompare = new string[1];
        [BitMask(typeof(CollisionType))]
        public CollisionType isCollisionType = CollisionType.Trigger;
        [BitMask(typeof(Dimension))] [DrawAsNumber]
        public Dimension dimension = Dimension.ThreeD;
        [BitMask(typeof(StateToTrigger))]
        public StateToTrigger stateToTriggerOn = StateToTrigger.Enter;

        #region Trigger2D

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Enter) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Exit) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Stay) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        #endregion

        #region Trigger3D

        private void OnTriggerEnter(Collider other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Enter) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Exit) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Stay) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Trigger)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        #endregion

        #region Collision2D

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Enter) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }
    
        private void OnCollisionExit2D(Collision2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Exit) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }
    
        private void OnCollisionStay2D(Collision2D other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Stay) || !dimension.HasFlag(Dimension.TwoD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        #endregion

        #region Collsion3D

        private void OnCollisionEnter(Collision other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Enter) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }
    
        private void OnCollisionExit(Collision other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Exit) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }
    
        private void OnCollisionStay(Collision other)
        {
            if (!stateToTriggerOn.HasFlag(StateToTrigger.Stay) || !dimension.HasFlag(Dimension.ThreeD) ||
                !isCollisionType.HasFlag(CollisionType.Collision)) return;
            foreach (var tagToCompare in tagsToCompare)
            {
                if (other.gameObject.CompareTag(tagToCompare))
                {
                    getGameObject.Invoke(other.gameObject);
                }
            }
        }

        #endregion


        [Flags]
        public enum StateToTrigger
        {
            Enter = 1<<0,
            Exit = 1<<1,
            Stay = 1<<2
        }
    
        [Flags] [DrawAsNumber]
        public enum Dimension
        {
            TwoD = 1<<0,
            ThreeD = 1<<1
        }

        [Flags]
        public enum CollisionType
        {
            Trigger = 1<<0,
            Collision = 1<<1
        }
    }
}