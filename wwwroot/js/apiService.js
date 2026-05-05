const BASE_URL = "http://localhost:5122/api/";

// debugger;
const apiService = {
    async post(endpoint, data) {
        console.log("Sending data to API:" + data);
        const response = await fetch(`${BASE_URL}${endpoint}`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(data),
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error(`Api post failed : ${response.status} - ${errorText}`);
            throw new Error(errorText);
        }
        return response.json();
    },
    async put(endpoint, data) {
        const response = await fetch(`${BASE_URL}${endpoint}`, {
            method: "PUT",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(data),
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error(`Api put failed : ${response.status} - ${errorText}`);
            throw new Error(errorText);
        }
        return response.json();
    },
    async get(endpoint) {
        try {
            const response = await fetch(`${BASE_URL}${endpoint}`, {
                method: "GET",
            });

            if (!response.ok) {
                throw new Error(`Api get failed : ${response.status}`);
            }
            return response.json();
        } catch (error) {
            console.error(`GET Error (${endpoint}):`, error.message);
            throw error;
        }
    },
    async delete(endpoint) {
        const response = await fetch(`${BASE_URL}${endpoint}`, {
            method: "DELETE",
        });
    }
}