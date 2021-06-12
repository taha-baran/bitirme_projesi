using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

namespace CortexAccess
{
    public class emotivHareket : MonoBehaviour
    {
        private static string _profileName = "wasd"; // new profile name for creating or existed profile name for loading

        private static Training _trainer = new Training();
        private static bool _isSucceeded = false;
        private static bool _isProfileLoaded = false;
        private static string _currentAction = "";

        private static CortexClient _ctxClient;
        private static AutoResetEvent _readyForTrainingEvent = new AutoResetEvent(false);

        public CharacterController controller;
        public Transform cam;
        public float speed = 6f;
        public float turnSmoothTime = 0.1f;
        float turnSmoothVelocity;
        private float horizontal = 0f;
        private float vertical;
        public static int action = 0;


        void Start()
        {
            _ctxClient = CortexClient.Instance;
            _trainer.OnReadyForTraning += ReadyForTraining;
            _trainer.OnTrainingSucceeded += TrainingSucceededOK;
            _trainer.OnProfileLoaded += ProfileLoadedOK;
            _trainer.OnUnProfileLoaded += ProfileUnloadedOK;


            _trainer.Start("mentalCommand");
            Thread.Sleep(5000);
            _trainer.LoadProfile(_profileName);
            Thread.Sleep(1000);
            _trainer.getSignals();

        }

        // Update is called once per frame
        void Update()
        {
            if (action == 0)
            {
                vertical = 0f;
                horizontal = 0f;
            }
            else if (action == 1)
            {
                vertical = 1f;
                horizontal = 0f;
            }
            else if (action == 2)
            {
                vertical = -1f;
                horizontal = 0f;
            }
            else if (action == 3)
            {
                vertical = 0f;
                horizontal = 1f;
            }
            else if (action == 3)
            {
                vertical = 0f;
                horizontal = -1f;
            }
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                Debug.Log(cam.eulerAngles.y);
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }


        }

        private static void ProfileUnloadedOK(object sender, bool e)
        {
            
            _isProfileLoaded = false;
        }

        private static void ProfileLoadedOK(object sender, string profile)
        {
            _isProfileLoaded = true;
        }

        private static void TrainingSucceededOK(object sender, bool isSucceeded)
        {
            _isSucceeded = isSucceeded;
            
        }

        private static void ReadyForTraining(object sender, bool e)
        {
            _readyForTrainingEvent.Set();
        }

    }
}