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
type BasicInputMappingHelpPaintable =
    inherit HelpPaintable
    [<DefaultValue(false)>] val mutable gameInputMappingArray : GameInputMapping[]
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicInputMappingHelpPaintable.jclinitDone then
            BasicInputMappingHelpPaintable.jclinitDone <- true
            BasicInputMappingHelpPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicInputMappingHelpPaintable() : unit =
        this.NONE <- GameKeyFactory.getInstance().NONE
        ()
    
    new (gameInputMappingArray: GameInputMapping[], basicColor: BasicColor) as this =
        { inherit HelpPaintable("Help Screen", BasicColorFactory.getInstance().BLACK, basicColor) }
        then
            this.jfields_BasicInputMappingHelpPaintable()
            this.jctor1(gameInputMappingArray, basicColor)
    member this.jctor1(gameInputMappingArray: GameInputMapping[], basicColor: BasicColor) : unit =
        ()
        this.gameInputMappingArray <- gameInputMappingArray
        this.update(this.NONE, this.NONE)
        ()
    
    abstract update : selectedGameKey: GameKey * selectedInput: Input -> unit
    default this.update(selectedGameKey: GameKey, selectedInput: Input) : unit =
        let mutable gameKeyMapping : PersistentInputMapping = PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance()
        let mutable EQUAL : string = " = "
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable size : int = this.gameInputMappingArray.Length
        let mutable keyInfo : string[] = (Array.zeroCreate<string> (size))
        let mutable gameInputMapping : GameInputMapping = null
        let mutable gameKey : GameKey = null
        let mutable list_ : BasicArrayList = null
        let mutable index : int = 0
        while index < size do
            gameInputMapping <- this.gameInputMappingArray.[index]
            gameKey <- gameInputMapping.getGameKey()
            list_ <- gameKeyMapping.getInputMapping().getMappedInput(gameKey)
            ignore (stringMaker.delete(0, stringMaker.length()))
            keyInfo.[index] <- stringMaker.append(gameInputMapping.getName()).append(EQUAL).append(this.get(list_)).ToString()
            index <- index + 1
        base.setInputInfoP(keyInfo)
    
    member this.get(keyList: BasicArrayList) : string =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable AND : string = "and "
        let mutable key : Input = null
        let mutable size : int = keyList.size()
        let mutable index : int = 0
        while index < size do
            key <- (box (keyList.objectArray.[index]) :?> Input)
            ignore (stringBuffer.append(key.getName()))
            if (index + 1) < keyList.size() then
                if keyList.size() = 2 then
                    ignore (stringBuffer.append(commonSeps.SPACE).append(AND))
                else
                    if (index + 2) = keyList.size() then
                        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
                        ignore (stringBuffer.append(AND))
                    else
                        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
            index <- index + 1
        stringBuffer.ToString()


