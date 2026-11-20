namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type PersistanceStrings =
    [<DefaultValue(false)>] val mutable SAVING : string
    [<DefaultValue(false)>] val mutable NUMBER_OF_RECORDS : string
    [<DefaultValue(false)>] val mutable LOADING_ID : string
    [<DefaultValue(false)>] val mutable LOAD_ALL : string
    [<DefaultValue(false)>] val mutable DELETING_WITH_ID : string
    [<DefaultValue(false)>] val mutable CLOSING_RECORDSTORE : string
    [<DefaultValue(false)>] val mutable NOT_SAVING : string
    [<DefaultValue(false)>] val mutable ERROR_LOADING : string
    [<DefaultValue(false)>] val mutable ERROR_LOADING_ID : string
    [<DefaultValue(false)>] val mutable ID : string
    [<DefaultValue(false)>] val mutable GAME_ACTION_INPUT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PersistanceStrings
    static member instance with get() : PersistanceStrings = (PersistanceStrings.jclinit(); PersistanceStrings.jcell_instance) and set (jvalue: PersistanceStrings) = (PersistanceStrings.jclinit(); PersistanceStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PersistanceStrings.jclinitDone then
            PersistanceStrings.jclinitDone <- true
            PersistanceStrings.jclinitBody()
    static member private jclinitBody() : unit =
        PersistanceStrings.jcell_instance <- (new PersistanceStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_PersistanceStrings()
    member this.jfields_PersistanceStrings() : unit =
        this.SAVING <- "Saving: "
        this.NUMBER_OF_RECORDS <- "Number of records: "
        this.LOADING_ID <- "Loading data with id: "
        this.LOAD_ALL <- "loadAll"
        this.DELETING_WITH_ID <- "Deleting data with id: "
        this.CLOSING_RECORDSTORE <- "Closing RecordStore"
        this.NOT_SAVING <- "Not Saving: "
        this.ERROR_LOADING <- "Error Loading gameActionInput: "
        this.ERROR_LOADING_ID <- "Error Loading id: "
        this.ID <- " id: "
        this.GAME_ACTION_INPUT <- " GameActionInput: "
        ()
    
    static member getInstance() : PersistanceStrings =
        PersistanceStrings.instance


