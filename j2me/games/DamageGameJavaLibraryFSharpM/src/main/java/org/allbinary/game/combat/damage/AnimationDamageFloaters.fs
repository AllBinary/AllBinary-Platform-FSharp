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
type AnimationDamageFloaters =
    inherit DamageFloaters
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable layerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable animationInterfaceArray : IndexedAnimation[]
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationDamageFloaters.jclinitDone then
            AnimationDamageFloaters.jclinitDone <- true
            AnimationDamageFloaters.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AnimationDamageFloaters() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (layerInterface: AllBinaryLayer, animationInterfaceArray: IndexedAnimation[], dx: int, dy: int) as this =
        { inherit DamageFloaters() }
        then
            this.jfields_AnimationDamageFloaters()
            this.jctor1(layerInterface, animationInterfaceArray, dx, dy)
    member this.jctor1(layerInterface: AllBinaryLayer, animationInterfaceArray: IndexedAnimation[], dx: int, dy: int) : unit =
        this.animationInterfaceArray <- animationInterfaceArray
        let mutable index : int = this.animationInterfaceArray.Length - 1
        while index >= 0 do
            this.animationInterfaceArray.[index].setFrame((this.animationInterfaceArray.[index].getSize() - 1))
            index <- index - 1
        this.layerInterface <- layerInterface
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.animationInterfaceArray.Length)
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.add(damage: int) : unit =
        let mutable i : int = this.circularIndexUtil.getIndex()
        this.animationInterfaceArray.[i].setFrame(0)
        ignore (this.circularIndexUtil.next())
    
    override this.paint(graphics: Graphics) : unit =
        try
            let mutable viewPosition : ViewPositionBase = this.layerInterface.getViewPosition()
            let mutable x : int = viewPosition.getX()
            let mutable y : int = viewPosition.getY()
            let mutable index : int = 0
            while index < this.animationInterfaceArray.Length do
                let mutable animationInterface : IndexedAnimation = this.animationInterfaceArray.[index]
                if animationInterface.getFrame() < (animationInterface.getAnimationSize() - 1) then
                    let mutable delta : int = animationInterface.getFrame() * 20
                    animationInterface.paintXY(graphics, (x + this.dx), ((y - delta) + this.dy))
                    animationInterface.nextFrame()
                index <- index + 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                let mutable canvasStrings : CanvasStrings = CanvasStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, canvasStrings.PAINT, e)
            | _ -> reraise ()


