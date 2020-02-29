# hw3csc631
HW 3 - CSC631

```Team: Ye Lu, Sara Tama, Jesse Hurtado```

Parts:
    
    a, b, c - Ye
   
    d, e, f - Sara
    
    g, h - Jesse
    

a. Make camera move (i) behind of object as the object moves (like the cube) and (ii) a top
down view that looks down the whole scene and switch between (i) and (ii) should be
done by key inut.
        
        Ye: Added camera following the truck and in two different angles.
  

b. Demonstrate that you can add texture and shading effects on the objects in the scene
and change them with button clicks.
     
     Ye: Created a button and associated it with a function changeMaterial() in the “obstacle” object.
           When the button is clicked, it calls this function and changed the rendering material of the
           obstacle.


c. Demonstrate that your objects can respond to collision (and physics properly) and add
special effects as a consequence of collision.
       
       Ye: When the truck collides with the barrel it responds by causing an explosion. Colliding with obstacles makes them move with the force.


d. Add particle effects something like this --
https://www.youtube.com/watch?v=xenW67bXTgM
       
       Sara: Added smoke particle effects coming out of the barrel.


e. A button makes a scene transition (so you should make at least 2 scene)
       
       Sara: Pressing "y" transitions to "lv3" scene.


f. A button activates simple character animation

       
       Sara: Pressing "w" makes the truck jump and do 360 flip.


g. A button changes shading effect (day to night scene or something else)
       
       Jesse: Pressing "x" makes the scene go day to night.


h. Mouse click picks up an object or creates (instantiates) an object in a scene
       
       Jesse: Added clicking and dragging the truck.
