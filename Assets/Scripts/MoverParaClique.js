 var smooth:int; // Determines how quickly object moves towards position
 var speed : int;
 private var targetPosition:Vector3;
 function Start () {
	 speed = 35;
	 smooth = 2;
	 targetPosition = transform.position;
 }
 function Update () {
     if(Input.GetKey(KeyCode.Mouse1))
     {
         var playerPlane = new Plane(Vector3.up, transform.position);
         var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         var hitdist = 0.0;
         
         if (playerPlane.Raycast (ray, hitdist)) {
             var targetPoint = ray.GetPoint(hitdist);
             targetPosition = ray.GetPoint(hitdist);
             var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
             transform.rotation = targetRotation;
         }
     }
     
     transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
 }