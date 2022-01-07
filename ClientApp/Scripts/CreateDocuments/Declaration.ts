import axios from "axios";
import Declaration from "../../Config/Objects/Docs/Declaration";

export function declarationRequest(declaration: Declaration): string
{
    let downloadLink: string = "";

    axios(
        {
            method: "post",
            url: "api/CreateDocs/GetDeclaration",
            data: JSON.stringify(declaration),
            headers: {"Content-Type": "application/json"},
            responseType: "blob",
        })
        .then((response: any) => {
            downloadLink = window.URL.createObjectURL(new Blob([response.data]));

            var a = document.createElement("a");
            document.body.appendChild(a);
            a.href = downloadLink;
            a.download = "Заявление-декларация.docx";
            a.click();
            document.body.removeChild(a);
        })
        .catch()

    return downloadLink;
}