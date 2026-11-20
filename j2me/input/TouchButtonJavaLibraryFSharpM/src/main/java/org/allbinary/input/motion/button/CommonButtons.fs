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
type CommonButtons =
    [<DefaultValue(false)>] val mutable STANDARD_BUTTON_SIZE : int
    [<DefaultValue(false)>] val mutable NORMAL_BUTTON : Rectangle
    [<DefaultValue(false)>] val mutable LARGE_BUTTON : Rectangle
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonButtons
    static member instance with get() : CommonButtons = (CommonButtons.jclinit(); CommonButtons.jcell_instance) and set (jvalue: CommonButtons) = (CommonButtons.jclinit(); CommonButtons.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonButtons.jclinitDone then
            CommonButtons.jclinitDone <- true
            CommonButtons.jclinitBody()
    static member private jclinitBody() : unit =
        CommonButtons.jcell_instance <- (new CommonButtons())
        ()
    
    static member getInstance() : CommonButtons =
        CommonButtons.instance
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable jflow = 0
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable commonButtonSize : int = 128
        while jflow = 0 && (commonButtonSize > 64) do
            let mutable totalColumns : int = displayInfo.getLastWidth() / commonButtonSize
            let mutable totalRows : int = displayInfo.getLastHeight() / commonButtonSize
            let mutable max_ : int = totalColumns
            if totalRows > max_ then
                max_ <- totalRows
            if max_ > 9 then
                jflow <- 100001
            if jflow = 0 then
                commonButtonSize <- commonButtonSize >>> 1
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            this.STANDARD_BUTTON_SIZE <- commonButtonSize
            this.NORMAL_BUTTON <- (new Rectangle(PointFactory.getInstance().ZERO_ZERO, this.STANDARD_BUTTON_SIZE, this.STANDARD_BUTTON_SIZE))
            this.LARGE_BUTTON <- (new Rectangle(PointFactory.getInstance().ZERO_ZERO, (this.STANDARD_BUTTON_SIZE <<< 1), (this.STANDARD_BUTTON_SIZE <<< 1)))
        ()


