import React from 'react'
import { Navigate } from 'react-router-dom'

export const PrivateRoutes = ({ children }) => {
    const isAuthenticated = true;

    if (isAuthenticated) {
        return children
    }

    return <Navigate to="/" />
}