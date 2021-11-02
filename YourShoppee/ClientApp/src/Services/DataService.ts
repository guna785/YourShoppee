import axios from "axios";
export default class DataService {
    getAbsoluteDomainUrl(): string {
        if (window
            && "location" in window
            && "protocol" in window.location
            && "host" in window.location) {
            return window.location.protocol + "//" + window.location.host;
        }
        return "";
    }
    
    Authticate=async (login:any)=>{
        console.log(this.getAbsoluteDomainUrl());
        const res=await axios.post(`${this.getAbsoluteDomainUrl()}/api/Account/Auth/`,login);
        return res;
    }

}