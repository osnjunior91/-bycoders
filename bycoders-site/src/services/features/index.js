import { BycodersApi } from "../axios";

const GetTransactions = () => {
    return BycodersApi.get('/transaction/store/all');
}

const UploadFile = (file) => {
    const formData = new FormData();
    formData.append('file', file);
    return BycodersApi.post('/bulk/file/upload', formData);
}

export { GetTransactions, UploadFile }