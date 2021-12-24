import Act from "../../Config/Objects/Docs/Act";
import axios from "axios";

export function actRequest(act: Act): string
{
    let downloadLink: string = "";
    
    axios(
        {
            method: "post",
            url: "api/CreateDocs/GetAct",
            data: JSON.stringify(act),
            headers: {"Content-Type": "application/json"},
            responseType: "blob",
        })
        .then((response: any) => {
            downloadLink = window.URL.createObjectURL(new Blob([response.data]));

            var a = document.createElement("a");
            document.body.appendChild(a);
            a.href = downloadLink;
            a.download = "Акт измерения.docx";
            a.click();
            document.body.removeChild(a);
        })
        .catch()
    
    return downloadLink;
}