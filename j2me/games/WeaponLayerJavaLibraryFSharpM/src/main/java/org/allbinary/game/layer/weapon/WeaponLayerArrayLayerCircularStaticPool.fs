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
type WeaponLayerArrayLayerCircularStaticPool =
    [<DefaultValue(false)>] val mutable MAX : int
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable WEAPONLAYER_ARRAY : WeaponLayer[][]
    [<DefaultValue(false)>] val mutable TWO_WEAPONLAYER_ARRAY : WeaponLayer[][]
    [<DefaultValue(false)>] val mutable THREE_WEAPONLAYER_ARRAY : WeaponLayer[][]
    [<DefaultValue(false)>] static val mutable private jcell_instance : WeaponLayerArrayLayerCircularStaticPool
    static member instance with get() : WeaponLayerArrayLayerCircularStaticPool = (WeaponLayerArrayLayerCircularStaticPool.jclinit(); WeaponLayerArrayLayerCircularStaticPool.jcell_instance) and set (jvalue: WeaponLayerArrayLayerCircularStaticPool) = (WeaponLayerArrayLayerCircularStaticPool.jclinit(); WeaponLayerArrayLayerCircularStaticPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WeaponLayerArrayLayerCircularStaticPool.jclinitDone then
            WeaponLayerArrayLayerCircularStaticPool.jclinitDone <- true
            WeaponLayerArrayLayerCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        WeaponLayerArrayLayerCircularStaticPool.jcell_instance <- (new WeaponLayerArrayLayerCircularStaticPool())
        ()
    new () as this =
        {  }
        then
            this.jfields_WeaponLayerArrayLayerCircularStaticPool()
    member this.jfields_WeaponLayerArrayLayerCircularStaticPool() : unit =
        this.MAX <- 5
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.MAX)
        this.WEAPONLAYER_ARRAY <- (Array.zeroCreate<WeaponLayer[]> (this.MAX * 2))
        this.TWO_WEAPONLAYER_ARRAY <- (Array.zeroCreate<WeaponLayer[]> (this.MAX))
        this.THREE_WEAPONLAYER_ARRAY <- (Array.zeroCreate<WeaponLayer[]> (this.MAX))
        ()
    
    static member getInstance() : WeaponLayerArrayLayerCircularStaticPool =
        WeaponLayerArrayLayerCircularStaticPool.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable index : int = 0
        while index < this.MAX do
            this.WEAPONLAYER_ARRAY.[index] <- (Array.zeroCreate<WeaponLayer> (1))
            this.TWO_WEAPONLAYER_ARRAY.[index] <- (Array.zeroCreate<WeaponLayer> (2))
            this.THREE_WEAPONLAYER_ARRAY.[index] <- (Array.zeroCreate<WeaponLayer> (3))
            index <- index + 1
        this.WEAPONLAYER_ARRAY <- this.WEAPONLAYER_ARRAY
        this.TWO_WEAPONLAYER_ARRAY <- this.TWO_WEAPONLAYER_ARRAY
        this.THREE_WEAPONLAYER_ARRAY <- this.THREE_WEAPONLAYER_ARRAY
    
    member this.getWeaponLayerArrays(size: int) : WeaponLayer[][] =
        let mutable jflow = 0
        let mutable jret : WeaponLayer[][] = Unchecked.defaultof<WeaponLayer[][]>
        if size = 1 then
            jret <- this.WEAPONLAYER_ARRAY
            jflow <- 1
        elif size = 2 then
            jret <- this.TWO_WEAPONLAYER_ARRAY
            jflow <- 1
        elif size = 3 then
            jret <- this.THREE_WEAPONLAYER_ARRAY
            jflow <- 1
        if jflow = 0 then
            raise ((new JRuntimeException()))
        jret
    
    abstract getInstanceArray : size: int -> WeaponLayer[]
    default this.getInstanceArray(size: int) : WeaponLayer[] =
        let mutable weaponLayerArray : WeaponLayer[] = this.getWeaponLayerArrays(size).[this.circularIndexUtil.getIndex()]
        ignore (this.circularIndexUtil.next())
        weaponLayerArray


