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
type MineWeaponResources =
    inherit BasicGameResources
    [<DefaultValue(false)>] val mutable DROP_TEXT_RESOURCE : string
    [<DefaultValue(false)>] val mutable DROP_RESOURCE : string
    [<DefaultValue(false)>] val mutable DROP_ICON_RESOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (MineWeaponResources.jclinit(); MineWeaponResources.jcell_instance) and set (jvalue: obj) = (MineWeaponResources.jclinit(); MineWeaponResources.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineWeaponResources.jclinitDone then
            MineWeaponResources.jclinitDone <- true
            MineWeaponResources.jclinitBody()
    static member private jclinitBody() : unit =
        MineWeaponResources.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_MineWeaponResources() : unit =
        this.DROP_TEXT_RESOURCE <- "/mine_drop_text_20_by_20.png"
        this.DROP_RESOURCE <- "/mine_drop_20_by_20.png"
        this.DROP_ICON_RESOURCE <- "/mine_drop_icon_20_by_20.png"
        ()
    
    static member getInstance() : MineWeaponResources =
        if (JR.same(MineWeaponResources.instance, NullUtil.getInstance().NULL_OBJECT)) then
            MineWeaponResources.instance <- (new MineWeaponResources())
        (box (MineWeaponResources.instance) :?> MineWeaponResources)
    
    new () as this =
        { inherit BasicGameResources() }
        then
            this.jfields_MineWeaponResources()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable ROOT : string = "/mine"
        let mutable SMALL : string = "_20_by_20.png"
        let mutable MEDIUM : string = SMALL
        let mutable SIZE_FOUR : string = SMALL
        let mutable SIZE_FIVE : string = SMALL
        let mutable SIZE_SIX : string = SMALL
        let mutable SIZE : string[] = ([| SMALL; MEDIUM; SIZE_FOUR; SIZE_FIVE; SIZE_SIX |] : string[])
        base.init(ROOT, SIZE)
        ()


