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
type GameConfigurationTextInput =
    [<DefaultValue(false)>] val mutable label : string
    [<DefaultValue(false)>] val mutable text : string
    [<DefaultValue(false)>] static val mutable private jcell_hashtable : ABHashtable
    static member hashtable with get() : ABHashtable = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_hashtable) and set (jvalue: ABHashtable) = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_hashtable <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SIMULATOR_IP : GameConfigurationTextInput
    static member SIMULATOR_IP with get() : GameConfigurationTextInput = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_SIMULATOR_IP) and set (jvalue: GameConfigurationTextInput) = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_SIMULATOR_IP <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SIMULATOR_PORT : GameConfigurationTextInput
    static member SIMULATOR_PORT with get() : GameConfigurationTextInput = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_SIMULATOR_PORT) and set (jvalue: GameConfigurationTextInput) = (GameConfigurationTextInput.jclinit(); GameConfigurationTextInput.jcell_SIMULATOR_PORT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfigurationTextInput.jclinitDone then
            GameConfigurationTextInput.jclinitDone <- true
            GameConfigurationTextInput.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfigurationTextInput.jcell_hashtable <- StdUtil.getInstance().createHashtable()
        GameConfigurationTextInput.jcell_SIMULATOR_IP <- (new GameConfigurationTextInput("IP: ", "192.168.1.3"))
        GameConfigurationTextInput.jcell_SIMULATOR_PORT <- (new GameConfigurationTextInput("Port: ", "8010"))
        ()
    member this.jfields_GameConfigurationTextInput() : unit =
        this.label <- StringUtil.getInstance().EMPTY_STRING
        this.text <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (label: string, text: string) as this =
        {  }
        then
            this.jfields_GameConfigurationTextInput()
            this.jctor1(label, text)
    member this.jctor1(label: string, text: string) : unit =
        this.setText(text)
        this.setLabel(label)
        ignore (GameConfigurationTextInput.hashtable.put(this.getLabel(), this))
        ()
    
    static member update(textField: TextField) : unit =
        let mutable anyType : obj = (box (textField.getLabel()))
        let mutable gameConfigurationTextInput : GameConfigurationTextInput = (box (GameConfigurationTextInput.hashtable.get(anyType)) :?> GameConfigurationTextInput)
        gameConfigurationTextInput.setText(textField.getString())
    
    abstract setText : text: string -> unit
    default this.setText(text: string) : unit =
        this.text <- text
    
    abstract getText : unit -> string
    default this.getText() : string =
        this.text
    
    abstract setLabel : label: string -> unit
    default this.setLabel(label: string) : unit =
        this.label <- label
    
    abstract getLabel : unit -> string
    default this.getLabel() : string =
        this.label
    
    static member getHashtable() : ABHashtable =
        GameConfigurationTextInput.hashtable


