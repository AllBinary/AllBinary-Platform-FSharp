namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type AllBinaryCollisionManager =
    [<DefaultValue(false)>] static val mutable private jcell_allBinaryCollisionManager : AllBinaryCollisionManager
    static member allBinaryCollisionManager with get() : AllBinaryCollisionManager = (AllBinaryCollisionManager.jclinit(); AllBinaryCollisionManager.jcell_allBinaryCollisionManager) and set (jvalue: AllBinaryCollisionManager) = (AllBinaryCollisionManager.jclinit(); AllBinaryCollisionManager.jcell_allBinaryCollisionManager <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryCollisionManager.jclinitDone then
            AllBinaryCollisionManager.jclinitDone <- true
            AllBinaryCollisionManager.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryCollisionManager.jcell_allBinaryCollisionManager <- (new AllBinaryCollisionManager())
        ()
    
    new () =
        {  }
    
    static member getInstance() : AllBinaryCollisionManager =
        AllBinaryCollisionManager.allBinaryCollisionManager
    
    abstract process_ : layerManager: LayerManager * collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface * startIndex: int -> unit
    default this.process_(layerManager: LayerManager, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface, startIndex: int) : unit =
        let mutable size : int = layerManager.getSize()
        let mutable index : int = startIndex + 1
        while index < size do
            let mutable collidableInterfaceCompositeInterface2 : CollidableInterfaceCompositeInterface = (box (layerManager.getLayerAt(index)) :?> CollidableInterfaceCompositeInterface)
            this.collide(layerManager, collidableInterfaceCompositeInterface, collidableInterfaceCompositeInterface2)
            index <- index + 1
    
    member this.collide(layerManager: LayerManager, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface, collidableInterfaceCompositeInterface2: CollidableInterfaceCompositeInterface) : unit =
        let mutable collidableBase2 : CollidableBaseBehavior = collidableInterfaceCompositeInterface2.getCollidableInferface()
        let mutable collidableBase : CollidableBaseBehavior = collidableInterfaceCompositeInterface.getCollidableInferface()
        if collidableBase2.isCollidable((box (collidableInterfaceCompositeInterface) :?> CollidableCompositeLayer)) then
            if collidableBase.isCollisionInterface((box (collidableInterfaceCompositeInterface) :?> CollidableCompositeLayer), collidableInterfaceCompositeInterface2) then
                collidableBase.collideInterface((box (collidableInterfaceCompositeInterface) :?> CollidableCompositeLayer), collidableInterfaceCompositeInterface2)
                collidableBase2.collideInterface((box (collidableInterfaceCompositeInterface) :?> CollidableCompositeLayer), collidableInterfaceCompositeInterface)


