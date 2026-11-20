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
type PtsDamageFloaters =
    inherit DamageFloaters
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable layerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable lastDamage : int[]
    [<DefaultValue(false)>] val mutable lastDamageString : char[][]
    [<DefaultValue(false)>] val mutable lastDamageStringSizeArray : int[]
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable primitiveLongUtil : PrimitiveLongUtil
    [<DefaultValue(false)>] val mutable myRandomFactory : MyRandomFactory
    [<DefaultValue(false)>] static val mutable private jcell_basicColorArrayIndexer : BasicColorArrayIndexer
    static member basicColorArrayIndexer with get() : BasicColorArrayIndexer = (PtsDamageFloaters.jclinit(); PtsDamageFloaters.jcell_basicColorArrayIndexer) and set (jvalue: BasicColorArrayIndexer) = (PtsDamageFloaters.jclinit(); PtsDamageFloaters.jcell_basicColorArrayIndexer <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PtsDamageFloaters.jclinitDone then
            PtsDamageFloaters.jclinitDone <- true
            PtsDamageFloaters.jclinitBody()
    static member private jclinitBody() : unit =
        PtsDamageFloaters.jcell_basicColorArrayIndexer <- (new BasicColorArrayIndexer(([| BasicColorFactory.getInstance().WHITE; BasicColorFactory.getInstance().RED; BasicColorFactory.getInstance().YELLOW; BasicColorFactory.getInstance().BLUE |] : BasicColor[])))
        ()
    member this.jfields_PtsDamageFloaters() : unit =
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.lastDamage <- (Array.zeroCreate<int> (5))
        this.lastDamageString <- (JR.newArray2<char>(5, 0))
        this.lastDamageStringSizeArray <- (Array.zeroCreate<int> (5))
        this.circularIndexUtil <- CircularIndexUtil.createInstance(5)
        this.myRandomFactory <- MyRandomFactory.getInstance()
        ()
    
    new (layerInterface: AllBinaryLayer) as this =
        { inherit DamageFloaters() }
        then
            this.jfields_PtsDamageFloaters()
            this.jctor1(layerInterface)
    member this.jctor1(layerInterface: AllBinaryLayer) : unit =
        this.primitiveLongUtil <- PrimitiveLongUtil.createPowerOfTen(100000)
        this.layerInterface <- layerInterface
        let mutable CHAR_ARRAY : char[] = CharArrayFactory.getInstance().getZeroCharArray()
        let mutable index : int = this.lastDamageString.Length - 1
        while index >= 0 do
            this.lastDamageString.[index] <- CHAR_ARRAY
            index <- index - 1
        ()
    
    override this.add(damage: int) : unit =
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.lastDamage.[index] <- damage
        this.lastDamageString.[index] <- this.primitiveLongUtil.getCharArray(this.lastDamage.[index])
        this.lastDamageStringSizeArray.[index] <- this.primitiveLongUtil.getCurrentTotalDigits()
        ignore (this.circularIndexUtil.next())
    
    override this.paint(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.layerInterface.getViewPosition()
        let mutable x : int = viewPosition.getX()
        let mutable y : int = viewPosition.getY()
        let mutable index : int = this.lastDamage.Length - 1
        while index >= 0 do
            if this.lastDamage.[index] <> 0 then
                let mutable delta : int = 10 * (index + 2)
                this.basicSetColorUtil.setBasicColorP(graphics, PtsDamageFloaters.basicColorArrayIndexer.get())
                graphics.drawChars(this.lastDamageString.[index], 0, this.lastDamageStringSizeArray.[index], (x - this.myRandomFactory.getNextInt(delta)), (y - delta), 0)
                ignore (PtsDamageFloaters.basicColorArrayIndexer.next())
            this.lastDamage.[index] <- 0
            index <- index - 1


