namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type AppNameLicensingAdConfiguration =
    inherit AdConfiguration
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AppNameLicensingAdConfiguration.jclinitDone then
            AppNameLicensingAdConfiguration.jclinitDone <- true
            AppNameLicensingAdConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit AdConfiguration(([| StringUtil.getInstance().EMPTY_STRING; StringUtil.getInstance().EMPTY_STRING; StringUtil.getInstance().EMPTY_STRING |] : obj[])) }


